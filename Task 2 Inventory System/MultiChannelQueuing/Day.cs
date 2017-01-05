using System;
using System.Threading;

namespace InventorySystemTask
{
    public class Day
    {
        public int id;
        public int typeRandomDigits;    //Randomly generated number for selecting the day type.
        public int type;    //Index of type from the input data grid.
        public int demandRandomDigits;  //Randomly generated number for selecting demand for the day.
        public int demand;  //The time at which the server started serving the customer.
        public double revenueFromSales; //Total revenue from the sale of papers in this day.
        public double lostProfitExcessDemand; // how much profit could have been made if more papers have been bought. (demand was bigger than purchased.)
        public double salvageOfScrap;   //Recovered amount by selling the leftover papers. (demand was less than purchased.)
        public double profit;   //Net profit for the day.

        public Day() { }

        public void CalcType()
        {
            typeRandomDigits = Program.mForm.simulation.dayTypeRandomValues[this.GetID()];// Get the random value for the day from the random values list.
            int type = -1;
            for (int i = 0; i < InventorySystem.newsdayType.Count; i++)
            {
                //Check to which domain does the random probability belong to, and use the corresponding entry as our day type (value is index of type).
                if (typeRandomDigits >= InventorySystem.newsdayType[i].rangeMin && typeRandomDigits <= InventorySystem.newsdayType[i].rangeMax)
                    type = i;
            }
            this.type = type;
        }
        public void CalcDemand()
        {
            demandRandomDigits = Program.mForm.simulation.demandRandomValues[this.GetID()];
            int demand = -1;
            for (int i = 0; i < InventorySystem.demandProbability[type].Count; i++)
            {
                //Check to which domain does the random probability belong to, and use the corresponding entry as our day demand value.
                if (demandRandomDigits >= InventorySystem.demandProbability[type][i].rangeMin && demandRandomDigits <= InventorySystem.demandProbability[type][i].rangeMax)
                    demand = InventorySystem.demandProbability[type][i].value;
            }
            this.demand = demand;
        }
        public void CalcRevenueFromSale()
        {
            //Revenue from sale = actual number of papers sold * selling price per paper.
            revenueFromSales = Math.Min(InventorySystem.purchasedPapersCount, this.demand) * InventorySystem.sellingPrice;
        }
        public void CalcLostProfit()
        {
            if (this.demand <= InventorySystem.purchasedPapersCount)
            {
                this.lostProfitExcessDemand = 0;
                return;
            }
            //Lost profit = Number of short paper * profit per paper.
            this.lostProfitExcessDemand = (this.demand - InventorySystem.purchasedPapersCount) * InventorySystem.paperProfit;
        }
        public void CalcSalvage()
        {
            if (this.demand > InventorySystem.purchasedPapersCount)
            {
                this.salvageOfScrap = 0;
                return;
            }
            //Salvage Value = # of left over papers * scrap price.
            this.salvageOfScrap = (InventorySystem.purchasedPapersCount - this.demand) * InventorySystem.scrapValue;
        }
        public void CalcProfit()
        {
            //Profit = revenue - cost of papers - lost profit + salvage
            this.profit = ((revenueFromSales) - (InventorySystem.purchasingPrice * InventorySystem.purchasedPapersCount) - (lostProfitExcessDemand) + (salvageOfScrap));
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetID() { return this.id; }
        public int GetTypeRandomDigits() { return this.typeRandomDigits; }
        public string GetType() { return InventorySystem.typesNames[type]; }
        public int GetDemandRandomDigits() { return this.demandRandomDigits; }
        public int GetDemand() { return this.demand; }
        public string GetRevenueFromSales()
        {
            if (this.revenueFromSales == 0) return "-";
            return this.revenueFromSales.ToString("$0.00");
        }
        public string GetLostProfit()
        {
            if (this.lostProfitExcessDemand == 0) return "-";
            return this.lostProfitExcessDemand.ToString("$0.00");
        }
        public string GetSalvageOfScrap()
        {
            if (this.salvageOfScrap == 0) return "-";
            else return this.salvageOfScrap.ToString("$0.00");
        }
        public string GetProfit()
        {
            if (this.profit >= 0)
                return this.profit.ToString("$0.00");
            else { return "-$" + (-1 * this.profit).ToString("0.00"); }
        }
        public double GetProfitD()
        {
            return this.profit;
        }
    }
}
