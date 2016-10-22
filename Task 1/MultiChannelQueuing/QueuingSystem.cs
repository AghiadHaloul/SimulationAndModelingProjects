using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public class QueuingSystem
    {
        public QueuingSystem() {} // Most things happen in this class.
        double queueWaitingTime = 0;//Will be used for calculating average queue time
        int maxQueue = 0;// Maximum Number of people in the queue during the simulation.
        double queuedCustomersCounter = 0;//Total number of customers that has been queued. To be used in calculating the probability of entering the queue.
        public int serverSelectionMode = 0;// 0 : higest priority, 1 : random, 2 : least utilization.
        public static int maxDelay = -1;
        public static List<Time> interArrivalTime = new List<Time>(Program.theForm.systemDGV.Rows.Count);// probability table (slide 34)
        public static List<Server> servers = new List<Server>();// our servers.
        public List<Customer> customersList = new List<Customer>();
        public static int[] queueArray;// number of customers in queue at every given time.
        static Random R = new Random();//For randomly selecting the server.

        public void SetInterArrivalProbabilityTable( )
        {
            DataGridView d = Program.theForm.systemDGV;
            for (int i = 0; i < d.Rows.Count-1; i++)
            {
                interArrivalTime.Add(new MultiChannelQueuing.Time());
                interArrivalTime[i].duration = Convert.ToInt32(d.Rows[i].Cells[0].Value);
                interArrivalTime[i].probability = Convert.ToDouble(d.Rows[i].Cells[1].Value);
            }
            //Calculatig ranges and interArrivalProbability
            interArrivalTime[0].cumulativeProbability = interArrivalTime[0].probability;
            interArrivalTime[0].rangeMin = 0;
            interArrivalTime[0].rangeMax = Convert.ToInt32(100 * (interArrivalTime[0].cumulativeProbability));
            for (int i = 1; i < Program.theForm.systemDGV.Rows.Count -1; i++)
            {
                interArrivalTime[i].cumulativeProbability = interArrivalTime[i - 1].cumulativeProbability + interArrivalTime[i].probability;
                interArrivalTime[i].rangeMin = interArrivalTime[i - 1].rangeMax - 1;
                interArrivalTime[i].rangeMax = Convert.ToInt32(100 * (interArrivalTime[i].cumulativeProbability));
            }
        }
        
        public int GetFreeServer(int arrival,int lastEndTime)
        {
            int retVal = -1;

            if (serverSelectionMode == 0)//Highest Priority of free servers
            {
                int ID = -1;
                for (int j = servers.Count - 1; j >= 0; j--)//start searching for a free server starting from least priority
                {
                    if (servers[j].GetTimeServiceEnds() <= arrival)//server is free
                    {
                        ID = j;
                    }
                }

                if (ID == -1)//No free servers? Select the closest free one.
                {

                    int soonestTime = int.MaxValue;
                    for (int j = servers.Count - 1; j >= 0; j--)
                    {
                        if (servers[j].GetTimeServiceEnds() <= soonestTime)
                        {
                            ID = j;
                            soonestTime = servers[j].GetTimeServiceEnds();
                        }
                    }
                }
                retVal = ID;
            }
            else if(serverSelectionMode == 1)//Random
            {
                List<int> serversID = new List<int>();
                for (int j = 0; j < servers.Count; j++)//A list of free servers.
                {
                    if (servers[j].GetTimeServiceEnds() <= arrival)
                    {
                        serversID.Add(j);
                    }
                }
                if (serversID.Count != 0)
                {
                    retVal = serversID[R.Next(0, serversID.Count - 1)];//Pick any random free server.
                }
                else
                {
                    //Pick the nearest free server if no one is free
                    serverSelectionMode = 0;
                    retVal = GetFreeServer(arrival,lastEndTime);
                    serverSelectionMode = 1;
                }
            }

            else if (serverSelectionMode == 2)//Least utilization
            {
                double maxIdle = -1;
                int maxIdleID= -1;   
                for(int j=0;j<servers.Count;j++)//Assign to server with maximum idle time.
                {

                    if (servers[j].GetIdle(lastEndTime) > maxIdle)
                    {
                        maxIdle = servers[j].GetIdle(lastEndTime);
                        maxIdleID = j;
                    }
                }
                retVal = maxIdleID;
            }
            return retVal;
        }

        public void LaunchSimulation(int simulaionSize, List<Server> inputServers)
        {
            SetInterArrivalProbabilityTable();
            servers = inputServers;
            for (int i = 0; i < simulaionSize; i++)
            {
                Customer T = new Customer();
                T.SetId(i);// ID
                T.CalcInterArrival();//Inter Arrival Time (Randomly generated)
                if (i == 0)//Arrival Time
                {
                    T.SetArrivalTime(T.GetInterArrivalTime());
                }
                else
                {
                    // previousCustomer.arrivalTime + interArrivalTime
                    T.SetArrivalTime(customersList[i - 1].GetArrivalTime() + T.GetInterArrivalTime());
                }

                if (i == 0)//Server Index
                    T.SetServerIndex(GetFreeServer(T.GetArrivalTime(), -1));
                else
                    T.SetServerIndex(GetFreeServer(T.GetArrivalTime(), customersList[i - 1].GetServiceEnd()));

                T.SetServiceBegin(Math.Max(T.GetArrivalTime(), servers[T.GetServerIndex()].GetTimeServiceEnds()));//Service Begin
                T.CalcServiceDuration(T.GetServerIndex());//Service Duration (Randomly generated depending on the server)
                T.SetServiceEnd(T.GetServiceBegin() + T.GetServiceDuration());//Service End.
                
                T.SetDelay(T.GetServiceBegin() - T.GetArrivalTime());//Delay
                queueWaitingTime += T.GetDelay();
                if (T.GetDelay() != 0) queuedCustomersCounter++;
                maxDelay = Math.Max(T.GetDelay(), maxDelay);
                servers[T.GetServerIndex()].SetTimeServiceEnds(T.GetServiceEnd());//update server's serviceTimeEnding
                
                customersList.Add(T);
                servers[T.GetServerIndex()].AddStat(T.GetServiceDuration());//add service duration to the server's total work time (for stats)
                SimulationTable.addToOutput(Program.simulationTableForm.outputDataGrid,T);
            }
            
            Main.updateStats(
                Convert.ToString(queueWaitingTime / simulaionSize),//Average waiting time (in the queue). 
                Convert.ToString(QueueLength(simulaionSize)),// Maximum queue length. 
                Convert.ToString(Convert.ToDouble(queuedCustomersCounter / simulaionSize))//Probability that a customer wait in the queue. 
                );

            for(int i=0;i<servers.Count;i++)
            {
                //Average service time per server.
                SimulationTable.addToOutput(Program.simulationTableForm.dataGridView2, Convert.ToString(i), Convert.ToString(servers[i].GetAverageServiceTime()));
                //Idle time per server.
                SimulationTable.addToOutput(Program.simulationTableForm.dataGridView1, Convert.ToString(i), Convert.ToString(Math.Round((100*servers[i].GetIdle(customersList[simulaionSize-1].GetServiceEnd())),3)));
            }
        }

        public int QueueLength(int simulaionSize)
        {
            queueArray = new int[customersList[simulaionSize - 1].GetServiceEnd()];
            int maxOverlap = 0, currentOverlap = 0;
            int previous = 0, idx = 0;
            List<Tuple<int,int>> pointsOfTime = new List<Tuple<int,int>>(simulaionSize);
            for (int j = 0; j < simulaionSize; j++){
            Tuple<int,int> pair=new Tuple<int,int>(customersList[j].GetArrivalTime(),1);
            pointsOfTime.Add(pair);
            Tuple<int, int> pair2 = new Tuple<int, int>(customersList[j].GetServiceBegin(), -1);
            pointsOfTime.Add(pair2);
            }
            pointsOfTime.Sort();
            while(idx < pointsOfTime.Count){
            while(previous < pointsOfTime[idx].Item1){
                queueArray[previous++] = currentOverlap;
            }
            currentOverlap += pointsOfTime[idx].Item2;
            maxOverlap = Math.Max(maxOverlap, currentOverlap);
            idx++;
    }
    return maxOverlap;

        }
    }
}

