using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public class InventorySystem
    {
        public InventorySystem() { }
        public static int purchasedPapersCount = -1;
        public static double purchasingPrice = -1;
        public static double sellingPrice = -1;
        public static double scrapValue = -1;
        public static double paperProfit = sellingPrice - purchasingPrice;
        public static double totalRevenueFromSales = 0;
        public static double totalCostOfNewsPapers = 0;
        public static double totalLostProfit = 0;
        public static double totalSalvage = 0;
        public static double netProfit = 0;
        public static double numberOfExcess = 0;
        public static double numberofUnsold = 0;
        public static double maximumProfitPossible = -1;
        public static int optimalNumOfPurchase = -1;
        public List<int> dayTypeRandomValues = new List<int>();
        public List<int> demandRandomValues = new List<int>();

        public static List<Probability> newsdayType = new List<Probability>(Program.theForm.dayTypeDGV.Rows.Count);// Day Type List
        public static List<List<Probability>> demandProbability = new List<List<Probability>>();// Demand probability for each day type.
        public List<Day> daysList = new List<Day>();// The values that will be displayed in the simulation table.
        public static List<String> typesNames = new List<string>(); // for converting type index to string.
        
        public void SetNewsdayType()
        { // Loading from data grid views.
            DataGridView d = Program.theForm.dayTypeDGV;
            string typeString;
            for (int i = 0; i < d.Rows.Count-1; i++)
            {
                newsdayType.Add(new MultiChannelQueuing.Probability());
                newsdayType[i].valule = i;
                newsdayType[i].probability = Convert.ToDouble(d.Rows[i].Cells[1].Value);
                typeString = Convert.ToString(d.Rows[i].Cells[0].Value);
                typesNames.Add(typeString);
            }
            //Calculating the ranges.
            newsdayType[0].cumulativeProbability = newsdayType[0].probability;
            newsdayType[0].rangeMin = 0;
            newsdayType[0].rangeMax = Convert.ToInt32(100 * (newsdayType[0].cumulativeProbability));
            for (int i = 1; i < Program.theForm.dayTypeDGV.Rows.Count -1; i++)
            {
                newsdayType[i].cumulativeProbability = newsdayType[i - 1].cumulativeProbability + newsdayType[i].probability;
                newsdayType[i].rangeMin = newsdayType[i - 1].rangeMax + 1;
                newsdayType[i].rangeMax = Convert.ToInt32(100 * (newsdayType[i].cumulativeProbability));
            }
        }
        public void setDemandProbability()
        {
            // Loading from data grid views.
            DataGridView d = Program.theForm.DemandDGV;
            for (int i = 1; i < d.Columns.Count; i++)
            {
                List<Probability> L = new List<Probability>();
                for (int j = 0; j < d.Rows.Count; j++)
                {
                    L.Add(new MultiChannelQueuing.Probability());
                    L[j].valule = Convert.ToInt32(d.Rows[j].Cells[0].Value);
                    L[j].probability = Convert.ToDouble(d.Rows[j].Cells[i].Value);
                }
                demandProbability.Add(L);
            }
            //Calculating the ranges.
            for (int j = 0; j < demandProbability.Count; j++)
            {
                demandProbability[j][0].cumulativeProbability = demandProbability[j][0].probability;
                demandProbability[j][0].rangeMin = 0;
                demandProbability[j][0].rangeMax = Convert.ToInt32(100 * (demandProbability[j][0].cumulativeProbability));
                for (int i = 1; i < demandProbability[j].Count ; i++)
                {
                    demandProbability[j][i].cumulativeProbability = demandProbability[j][i - 1].cumulativeProbability + demandProbability[j][i].probability;
                    demandProbability[j][i].rangeMin = demandProbability[j][i - 1].rangeMax + 1;
                    demandProbability[j][i].rangeMax = Convert.ToInt32(100 * (demandProbability[j][i].cumulativeProbability));
                }
            }
        }
        public void LaunchSimulation(int numOfDays)
        {
            
            resetVals();
            SetPaperProfit();
            SetNewsdayType();
            setDemandProbability();
            for (int i = 0; i < numOfDays; i++)
            {
                Day day = new Day();
                day.SetId(i);
                if(day.GetID()==numOfDays)
                {
                    int x=0;
                    x ++;
                    int y = x;
                    x++;
                }
                day.CalcType();
                day.CalcDemand();
                day.CalcRevenueFromSale();
                day.CalcLostProfit();
                day.CalcSalvage();
                day.CalcProfit();
                daysList.Add(day);
                SimulationTable.addToOutput(Program.simulationTableForm.outputDataGrid, day);
                updateStats(day);
            }
            if (netProfit > maximumProfitPossible)//calculating the simulation final result.
            {
                optimalNumOfPurchase = purchasedPapersCount;
                maximumProfitPossible = netProfit;
            }
            Main.updateStats(totalRevenueFromSales.ToString("$0.00"),
                totalCostOfNewsPapers.ToString("$0.00"),
                totalLostProfit.ToString("$0.00"),
                totalSalvage.ToString("$0.00"),
                netProfit.ToString("$0.00"),
                numberOfExcess.ToString(),
                numberofUnsold.ToString(),
                optimalNumOfPurchase.ToString()+" ("+maximumProfitPossible.ToString("$0.00")+")"
                );
        }
        public void SetPurchasedPapersCount(int count)
        {
            purchasedPapersCount = count;
        }
        public void SetPurchasingPrice(double price)
        {
            purchasingPrice = price;
        }
        public void SetSellingPrice(double price)
        {
            sellingPrice = price;
        }
        public void SetScrapValue(double value)
        {
            scrapValue = value;
        }
        public void SetPaperProfit ()
        {
            paperProfit = sellingPrice - purchasingPrice;
        }
        public void updateStats(Day day)
        {
            totalRevenueFromSales += day.revenueFromSales;
            totalLostProfit += day.lostProfitExcessDemand;
            totalSalvage += day.salvageOfScrap;
            netProfit += day.profit;
            if (day.demand > purchasedPapersCount) numberOfExcess++;
            if (day.demand < purchasedPapersCount) numberofUnsold++;
            totalCostOfNewsPapers += purchasedPapersCount * purchasingPrice;
        }
        public void resetVals()
        {
         paperProfit = sellingPrice - purchasingPrice;
         totalRevenueFromSales = 0;
         totalCostOfNewsPapers = 0;
         totalLostProfit = 0;
         totalSalvage = 0;
         netProfit = 0;
         numberOfExcess = 0;
         numberofUnsold = 0;
         daysList.Clear();
        }
        
    }
}

