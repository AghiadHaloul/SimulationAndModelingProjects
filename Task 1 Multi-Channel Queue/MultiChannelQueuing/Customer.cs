using System;
using System.Threading;

namespace MultiChannelQueuing
{
    public class Customer
    {
        int id;
        int interArrivalTime; // Randomly generated number indicated the time difference between the entry time of the customer and the entry time of the one before him.
        int arrivalTime;      // previousCustomer.arrivalTime + interArrivalTime
        int serverIndex;    // 0 for able and 1 for baker
        int serviceBegin;// the time at which the server started serving the customer.
        int serviceDuration;
        int serviceEnd;
        int delay; // the amount of time the customer spent waiting until he was served by the server.
        int interArrivalProbability;
        int serviceDurationProbability;
        static Random time = new Random();
        public Customer() { }

        public int RandomProbability()
        {
           return time.Next(0, 100);
        }
        public void CalcInterArrival()
        {
            interArrivalProbability = RandomProbability();
            int time = -1;
            for (int i = 0; i < QueuingSystem.interArrivalTime.Count; i++)
            {
                // check to which domain does the random probability belogs to, and use the corresponding entry as our inter-arrival time.
                if (interArrivalProbability >= QueuingSystem.interArrivalTime[i].rangeMin && interArrivalProbability <= QueuingSystem.interArrivalTime[i].rangeMax)
                    time = QueuingSystem.interArrivalTime[i].duration;
            }
            this.interArrivalTime = time;
        }
        public void CalcServiceDuration(int server)
        {
            serviceDurationProbability = RandomProbability();
            int time = -1;
            for (int i = 0; i < QueuingSystem.servers[server].serviceTime.Count; i++)
            {
                // check to which domain does the random probability belogs to, and use the corresponding entry as our service duration time.
                if (serviceDurationProbability >= QueuingSystem.servers[server].serviceTime[i].rangeMin && serviceDurationProbability <= QueuingSystem.servers[server].serviceTime[i].rangeMax)
                    time = QueuingSystem.servers[server].serviceTime[i].duration;
            }
            this.serviceDuration = time;
        }
        public int GetID() { return id; }
        public int GetInterArrivalTime() { return interArrivalTime; }
        public int GetArrivalTime() { return arrivalTime; }
        public int GetServerIndex() { return serverIndex; }
        public int GetServiceBegin() { return serviceBegin; }
        public int GetServiceDuration() { return serviceDuration; }
        public int GetServiceEnd() { return serviceEnd; }
        public int GetDelay() { return delay; }
        public int GetServiceDurationProbaility() { return serviceDurationProbability; }
        public int GetInterArrivalProbability()
        {
            return interArrivalProbability;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetArrivalTime(int time)
        {
            this.arrivalTime = time;
        }
        public void SetServerIndex(int index)
        {
            this.serverIndex = index;
        }
        public void SetServiceBegin(int time)
        {
            this.serviceBegin = time;
        }
        public void SetServiceEnd(int time)
        {
            this.serviceEnd = time;
        }
        public void SetDelay(int delay)
        {
            this.delay = delay;
        }
    }
}
