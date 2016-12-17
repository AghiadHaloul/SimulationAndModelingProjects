using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public class Server
    {
        public List<Time> serviceTime;// probability table for service time. Check slides 34&35 Lab 1.
        double timeServiceEnds = -1; //When will the server be available next?
        int customersServed = 0;
        double serviceTimesSum = 0;
        double averageServiceTime;
        public double beta = -1;

        public static int counter = 0;
        public Server(double beta)
        {
            this.beta = beta;
            counter++;
        }
        public void SetTimeServiceEnds(double time)
        {
            this.timeServiceEnds = time;
        }
        public double GetTimeServiceEnds()
        {
            return this.timeServiceEnds;
        }
        public void AddStat(double time)
        {
            serviceTimesSum += time;
            customersServed++;
        }
        public string GetAverageServiceTime()
        {
            averageServiceTime = serviceTimesSum / customersServed;
            return Convert.ToString(Math.Round(averageServiceTime,3));
        }
        public double GetIdle(double totalSystemWork)
        {
            return 1-(Convert.ToDouble(GetIServiceTimeSum())/totalSystemWork);
        }
        public double GetIServiceTimeSum()
        {
            return Convert.ToDouble(serviceTimesSum);
        }
    }

}
