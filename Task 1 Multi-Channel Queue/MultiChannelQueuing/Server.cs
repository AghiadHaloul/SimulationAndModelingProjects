using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public class Server
    {
        public List<Time> serviceTime;// Probability table for service time. Check slides 34&35 Lab 1.
        int timeServiceEnds = -1;//When will the server be available next?
        int customersServed = 0;
        double serviceTimesSum = 0;
        double averageServiceTime;

        public static int counter = 0;
        public Server()
        {
            counter++;
        }
        public void SetServer()
        {
            // Load from dataGrid into a list
            DataGridView data = null;
            data = Program.mainForm.servrersDataGridView;
            serviceTime = new List<Time>(Program.mainForm.servrersDataGridView.Rows.Count);
            for (int i = 0; i < data.Rows.Count - 1; i++)
            {
                serviceTime.Add(new Time());
                serviceTime[i].duration = Convert.ToInt32(data.Rows[i].Cells[0].Value);
                serviceTime[i].probability = Convert.ToDouble(data.Rows[i].Cells[1].Value);
            }
            serviceTime[0].cumulativeProbability = serviceTime[0].probability;
            serviceTime[0].rangeMin = 0;
            serviceTime[0].rangeMax = Convert.ToInt32(100 * (serviceTime[0].cumulativeProbability));

            for (int i = 1; i < data.Rows.Count - 1; i++)
            {
                serviceTime[i].cumulativeProbability = serviceTime[i - 1].cumulativeProbability + serviceTime[i].probability;
                serviceTime[i].rangeMin = serviceTime[i - 1].rangeMax + 1;
                serviceTime[i].rangeMax = Convert.ToInt32(100 * (serviceTime[i].cumulativeProbability));
            }
        }
        public void SetTimeServiceEnds(int time)
        {
            this.timeServiceEnds = time;
        }
        public int GetTimeServiceEnds()
        {
            return this.timeServiceEnds;
        }
        public void AddStat(int time)
        {
            serviceTimesSum += time;
            customersServed++;
        }
        public string GetAverageServiceTime()
        {
            averageServiceTime = serviceTimesSum / customersServed;
            return Convert.ToString(Math.Round(averageServiceTime, 3));
        }
        public double GetIdle(int totalSystemWork)
        {
            return 1 - (Convert.ToDouble(GetIServiceTimeSum()) / totalSystemWork);
        }
        public int GetIServiceTimeSum()
        {
            return Convert.ToInt32(serviceTimesSum);
        }
    }

}
