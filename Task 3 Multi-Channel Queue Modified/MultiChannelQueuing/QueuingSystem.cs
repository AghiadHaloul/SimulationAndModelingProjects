using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public class QueuingSystem
    {
        public QueuingSystem() { } // Most things happen in this class.
        double queueWaitingTime = 0;//Will be used for calculating average queue time
        int maxQueue = 0;// Maximum Number of people in the queue during the simulation.
        double queuedCustomersCounter = 0;//Total number of customers that has been queued. To be used in calculating the probability of entering the queue.
        public int serverSelectionMode = 0;// 0 : higest priority, 1 : random, 2 : least utilization.
        public static double maxDelay = -1;
        public static List<Server> servers = new List<Server>();// our servers.
        public List<Customer> customersList = new List<Customer>();
        public static int[] queueArray;// number of customers in queue at every given time.
        static Random R = new Random();//For randomly selecting the server.
        public static double beta;
        public int GetFreeServer(double arrival, double lastEndTime)
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

                    double soonestTime = Double.MaxValue;
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
            else if (serverSelectionMode == 1)//Random
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
                    retVal = GetFreeServer(arrival, lastEndTime);
                    serverSelectionMode = 1;
                }
            }

            else if (serverSelectionMode == 2)//Least utilization
            {
                double maxIdle = -1;
                int maxIdleID = -1;
                for (int j = 0; j < servers.Count; j++)//Assign to server with maximum idle time.
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
            servers = inputServers;
            for (int i = 0; i < simulaionSize; i++)
            {
                Customer T = new Customer();
                T.SetId(i);// ID
                T.CalcInterArrival(beta);//Inter Arrival Time (Randomly generated)
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
                SimulationTable.addToOutput(Program.simulationTableForm.outputDataGrid, T);
            }

            Main.updateStats(
                Convert.ToString(queueWaitingTime / simulaionSize),//Average waiting time (in the queue). 
                Convert.ToString(QueueLength(simulaionSize)),// Maximum queue length. 
                Convert.ToString(Convert.ToDouble(queuedCustomersCounter / simulaionSize))//Probability that a customer wait in the queue. 
                );

            for (int i = 0; i < servers.Count; i++)
            {
                //Average service time per server.
                SimulationTable.addToOutput(Program.simulationTableForm.dataGridView2, Convert.ToString(i), Convert.ToString(servers[i].GetAverageServiceTime()));
                //Idle time per server.
                SimulationTable.addToOutput(Program.simulationTableForm.dataGridView1, Convert.ToString(i), Convert.ToString(Math.Round((100 * servers[i].GetIdle(customersList[simulaionSize - 1].GetServiceEnd())), 3)));
            }
        }

        public int QueueLength(int simulaionSize)
        {
            queueArray = new int[(int)Math.Round(customersList[simulaionSize - 1].GetServiceEnd())];
            int maxOverlap = 0, currentOverlap = 0;
            int previous = 0, idx = 0;
            List<Tuple<double, int>> pointsOfTime = new List<Tuple<double, int>>(simulaionSize);
            for (int j = 0; j < simulaionSize; j++)
            {
                Tuple<double, int> pair = new Tuple<double, int>(customersList[j].GetArrivalTime(), 1);
                pointsOfTime.Add(pair);
                Tuple<double, int> pair2 = new Tuple<double, int>(customersList[j].GetServiceBegin(), -1);
                pointsOfTime.Add(pair2);
            }
            pointsOfTime.Sort();
            while (idx < pointsOfTime.Count)
            {
                while (previous < pointsOfTime[idx].Item1)
                {
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

