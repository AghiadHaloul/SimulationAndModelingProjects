using System;
using System.Threading;

namespace MultiChannelQueuing
{
    public class Customer
    {
        int id;
        double interArrivalTime; // Randomly generated number indicated the time difference between the entry time of the customer and the entry time of the one before him.
        double arrivalTime;      // previousCustomer.arrivalTime + interArrivalTime
        int serverIndex;    // 0 for able and 1 for baker
        double serviceBegin;// the time at which the server started serving the customer.
        double serviceDuration;
        double serviceEnd;
        double delay; // the amount of time the customer spent waiting until he was served by the server.
        double interArrivalProbability;
        double serviceDurationProbability;
        static Random time = new Random();
        public Customer() { }

        public double RandomProbability()
        {
           return time.NextDouble();
        }
        public void CalcInterArrival(double beta)
        {
            interArrivalProbability = RandomProbability();
            this.interArrivalTime = -beta*Math.Log(interArrivalProbability);
        }
        public void CalcServiceDuration(int server)
        {
            serviceDurationProbability = RandomProbability();
            //this.serverIndex = server;
            this.serviceDuration = -QueuingSystem.servers[server].beta * Math.Log(serviceDurationProbability);
        }
        public int GetID() { return id; }
        public double GetInterArrivalTime() { return interArrivalTime; }
        public double GetArrivalTime() { return arrivalTime; }
        public int GetServerIndex() { return serverIndex; }
        public double GetServiceBegin() { return serviceBegin; }
        public double GetServiceDuration() { return serviceDuration; }
        public double GetServiceEnd() { return serviceEnd; }
        public double GetDelay() { return delay; }
        public  double GetServiceDurationProbaility() { return serviceDurationProbability; }
        public double GetInterArrivalProbability()
        {
            return interArrivalProbability;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetArrivalTime(double time)
        {
            this.arrivalTime = time;
        }
        public void SetServerIndex(int index)
        {
            this.serverIndex = index;
        }
        public void SetServiceBegin(double time)
        {
            this.serviceBegin = time;
        }
        public void SetServiceEnd(double time)
        {
            this.serviceEnd = time;
        }
        public void SetDelay(double delay)
        {
            this.delay = delay;
        }
    }
}
