using System;
using System.Collections.Generic;
using System.Threading;

namespace orderUpToLevelProblem
{
    public class Day
    {
        public int id { get; set; }
        public int cycle { get; set; }
        public int dayWithinCycle { get; set; }
        public int beginningInventory { get; set; }
        public int randomDigitsForDemand { get; set; }
        public int demand { get; set; }
        public int endingInventory { get; set; }
        public int shortageQuantity { get; set; }
        public int orderQuantity { get; set; }
        public int randomDigitsForLeadTime { get; set; }
        public int LeadTime { get; set; }
        public int daysUntilOrderArrives { get; set; }
        public int shortageSoFar { get; set; }
        public int alreadyOrdered { get; set; }
        public Day() { }
        public void SetDemand()
        {
            int demandVal = -1;
            for (int i = 0; i < RefrigeratorInventorySystem.demandProbability.Count; i++)
            {

                if (randomDigitsForDemand >= RefrigeratorInventorySystem.demandProbability[i].rangeMin && randomDigitsForDemand <= RefrigeratorInventorySystem.demandProbability[i].rangeMax)
                    demandVal = RefrigeratorInventorySystem.demandProbability[i].value;
            }
            this.demand = demandVal;
        }
        public void SetLeadTime()
        {
            int leadTimeVal = -1;
            for (int i = 0; i < RefrigeratorInventorySystem.leadTimeProbability.Count; i++)
            {

                if (randomDigitsForLeadTime >= RefrigeratorInventorySystem.leadTimeProbability[i].rangeMin && randomDigitsForLeadTime <= RefrigeratorInventorySystem.leadTimeProbability[i].rangeMax)
                    leadTimeVal = RefrigeratorInventorySystem.leadTimeProbability[i].value;
            }
            this.LeadTime = leadTimeVal;
        }
        public void SetId(int i)
        {
            this.id = i + 1;
        }
        public void SetCycle(int i, int reviewPeriod)
        {
            this.cycle = (i / reviewPeriod) + 1;
        }
        public void SetDayWithinCycle(int reviewPeriod)
        {
            this.dayWithinCycle = this.id - (reviewPeriod * (this.cycle - 1));
        }
        public void SetBeginningInventory(int i, List<Day> daysList)
        {
            if (i == 0)
            {
                this.beginningInventory = 3;
            }
            else
            {
                this.beginningInventory = daysList[i - 1].endingInventory;
            }
        }
        public void SetDaysUntilOrderArrives(int i, List<Day> daysList)
        {
            this.daysUntilOrderArrives = 0;
        }
        public void SetRandomDigitsForDemand(int i, int trialID, List<List<int>> demandPerDayRandomValues)
        {
            this.randomDigitsForDemand = demandPerDayRandomValues[trialID][i];
        }
        public void SetEndingInventory()
        {
            this.endingInventory = Math.Max(this.beginningInventory - this.demand, 0);
        }
        public void SetShortageQuantity(List<Day> daysList,int i)
        {
            this.shortageQuantity = Math.Max(this.demand - this.beginningInventory, 0);
            if ((i>0) && (this.daysUntilOrderArrives != -1 && daysList[i - 1].daysUntilOrderArrives != 0))
            {
                Program.mainForm.simulation.AddToShortageSoFar(shortageQuantity);
            }
        }
        public void SetOrderDetails(int reviewPeriod, int OrderUpToLevel, List<Day> daysList, int currentOrder, List<List<int>> leadTimeRandomValues, int trialID, int i)
        {
            if (this.dayWithinCycle == reviewPeriod)
            {
                this.orderQuantity = Math.Max(OrderUpToLevel - this.endingInventory,0);
                this.orderQuantity += Program.mainForm.simulation.shortageSoFar;
                Program.mainForm.simulation.alreadyOrdered = this.orderQuantity ;
                Program.mainForm.simulation.shortageSoFar = 0;
                Program.mainForm.simulation.lastOrder = this.orderQuantity;
                Program.mainForm.simulation.UpdateCurrentOrder(this.orderQuantity);
                this.randomDigitsForLeadTime = leadTimeRandomValues[trialID][i];
                this.SetLeadTime();
                this.daysUntilOrderArrives = this.LeadTime;
            }
            else
            {
                this.orderQuantity = 0;
                this.randomDigitsForLeadTime = -1;
                if (i > 0)
                {
                    if (daysList[i - 1].daysUntilOrderArrives != -1)
                    {
                        this.daysUntilOrderArrives = daysList[i - 1].daysUntilOrderArrives - 1;
                    }
                    if (daysList[i-1].daysUntilOrderArrives == -1)
                    {
                        this.daysUntilOrderArrives = -sizeof(int);
                    }
                    if (this.daysUntilOrderArrives == -1 && daysList[i-1].daysUntilOrderArrives==0)
                    {
                        this.daysUntilOrderArrives = -1;
                        this.beginningInventory += Program.mainForm.simulation.lastOrder;
                        this.endingInventory = Math.Max(this.beginningInventory - (this.beginningInventory - Program.mainForm.simulation.OrderUpToLevel), 0);
                        if (this.endingInventory != 0)
                        {
                            this.endingInventory = Math.Max(Math.Max(this.beginningInventory-(this.beginningInventory - Program.mainForm.simulation.OrderUpToLevel), 0) - this.demand, 0);
                            this.shortageQuantity = Math.Max(this.demand - this.endingInventory, 0);
                            Program.mainForm.simulation.AddToShortageSoFar(shortageQuantity);
                        }
                        Program.mainForm.simulation.ClearAlreadyOrdered();
                    }
                }
                else
                {
                    this.daysUntilOrderArrives = -sizeof(int);
                }
            }
        }
    }
}