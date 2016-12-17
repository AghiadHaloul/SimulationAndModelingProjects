using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
namespace orderUpToLevelProblem
{
    public class RefrigeratorInventorySystem
    {
        public RefrigeratorInventorySystem() { }
        public int OrderUpToLevel { get; set; }
        public int reviewPeriod { get; set; }
        public int numOfDays { get; set; }
        public int numOfTrials { get; set; }
        public int currentOrder { get; set; }
        public int shortageSoFar { get; set; }
        public int alreadyOrdered { get; set; }
        public int lastOrder { get; set; }
        public void ClearShortageSoFar() { shortageSoFar=0;}
        public void ClearAlreadyOrdered(){alreadyOrdered=0;}
        public void AddToShortageSoFar(int x) { shortageSoFar += x; }
        public static List<Probability> demandProbability = new List<Probability>();
        public static List<Probability> leadTimeProbability = new List<Probability>();
        public List<List<int>> demandPerDayRandomValues = new List<List<int>>();
        public List<List<int>> leadTimeRandomValues = new List<List<int>>();
        public double endingInventoryAverage { get; set; }
        public double shortageQuantityAverage { get; set; }
        public void ClearAverages()
        {
            endingInventoryAverage = 0;
            shortageQuantityAverage = 0;

        }
        public List<Day> daysList = new List<Day>();    //The values that will be displayed in the simulation table.
        public void ColorIt(Day day,int i)
        {
            if (day.daysUntilOrderArrives == -1)
            {
                for (int k = 11; k < 12; k++)
                {
                    Program.simulationTableForm.outputDataGrid.Rows[i].Cells[k].Style.BackColor = Color.LightGreen;
                }
            }
            if (day.shortageQuantity != 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[7].Style.BackColor = Color.LightPink;

            if (day.beginningInventory != 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;
            if (day.beginningInventory == 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[3].Style.BackColor = Color.LightPink;

            if (day.endingInventory != 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[6].Style.BackColor = Color.LightGreen;
            if (day.endingInventory == 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[6].Style.BackColor = Color.LightPink;

            if (day.demand != 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[5].Style.BackColor = Color.LightGreen;
            if (day.demand == 0)
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[5].Style.BackColor = Color.LightPink;

            if (day.LeadTime != 0)
            {
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[8].Style.BackColor = Color.LightBlue;
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[9].Style.BackColor = Color.LightBlue;
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[10].Style.BackColor = Color.LightBlue;
                Program.simulationTableForm.outputDataGrid.Rows[i].Cells[11].Style.BackColor = Color.LightBlue;
            }
            Program.simulationTableForm.outputDataGrid.Rows[i].Cells[6].Style.Alignment = 0;
        }

        public void setDemandProbability()
        {
            DataGridView d = Program.mainForm.demandDataGridView;
            for (int i = 0; i < d.Rows.Count - 1; i++)
            {
                demandProbability.Add(new orderUpToLevelProblem.Probability());
                demandProbability[i].value = Convert.ToInt32(d.Rows[i].Cells[0].Value);
                demandProbability[i].probability = Convert.ToDouble(d.Rows[i].Cells[1].Value);
            }
            //Calculating ranges 
            demandProbability[0].cumulativeProbability = demandProbability[0].probability;
            demandProbability[0].rangeMin = 0;
            demandProbability[0].rangeMax = Convert.ToInt32(100 * (demandProbability[0].cumulativeProbability));
            for (int i = 1; i < Program.mainForm.demandDataGridView.Rows.Count - 1; i++)
            {
                demandProbability[i].cumulativeProbability = demandProbability[i - 1].cumulativeProbability + demandProbability[i].probability;
                demandProbability[i].rangeMin = demandProbability[i - 1].rangeMax - 1;
                demandProbability[i].rangeMax = Convert.ToInt32(100 * (demandProbability[i].cumulativeProbability));
            }
        }
        public void setLeadProbability()
        {
            DataGridView d = Program.mainForm.leadTimeDataGridView;
            for (int i = 0; i < d.Rows.Count - 1; i++)
            {
                leadTimeProbability.Add(new orderUpToLevelProblem.Probability());
                leadTimeProbability[i].value = Convert.ToInt32(d.Rows[i].Cells[0].Value);
                leadTimeProbability[i].probability = Convert.ToDouble(d.Rows[i].Cells[1].Value);
            }
            //Calculating ranges
            leadTimeProbability[0].cumulativeProbability = leadTimeProbability[0].probability;
            leadTimeProbability[0].rangeMin = 0;
            leadTimeProbability[0].rangeMax = Convert.ToInt32(100 * (leadTimeProbability[0].cumulativeProbability));
            for (int i = 1; i < Program.mainForm.leadTimeDataGridView.Rows.Count - 1; i++)
            {
                leadTimeProbability[i].cumulativeProbability = leadTimeProbability[i - 1].cumulativeProbability + leadTimeProbability[i].probability;
                leadTimeProbability[i].rangeMin = leadTimeProbability[i - 1].rangeMax - 1;
                leadTimeProbability[i].rangeMax = Convert.ToInt32(100 * (leadTimeProbability[i].cumulativeProbability));
            }
        }
        public void UpdateCurrentOrder(int orderQuantity)
        {
            currentOrder = orderQuantity;
        }
        public void LaunchSimulation(int trialID,bool doAverage)
        {
            UpdateCurrentOrder(0);
            ClearShortageSoFar();
            ClearAlreadyOrdered();
            ClearAverages();
            Day day;
            daysList.Clear();
            for (int i = 0; i < numOfDays; i++)
            {
                day = new Day();
                day.SetId(i);
                day.SetCycle(i, reviewPeriod);
                day.SetDayWithinCycle(reviewPeriod);
                day.SetBeginningInventory(i,daysList);
                day.SetDaysUntilOrderArrives(i, daysList);
                day.SetRandomDigitsForDemand(i, trialID, demandPerDayRandomValues);
                day.SetDemand();
                day.SetEndingInventory();
                day.SetShortageQuantity(daysList,i);
                day.SetOrderDetails(reviewPeriod, OrderUpToLevel, daysList, currentOrder, leadTimeRandomValues,trialID,i);
                day.shortageSoFar = shortageSoFar;
                day.alreadyOrdered = alreadyOrdered;
                daysList.Add(day);
                SimulationTable.AddToOutput(Program.simulationTableForm.outputDataGrid, day);
                ColorIt(day, i);
                endingInventoryAverage += day.endingInventory;
                shortageQuantityAverage += day.shortageQuantity;
                
            }
            endingInventoryAverage = Math.Round(endingInventoryAverage / numOfDays, 2);
            shortageQuantityAverage = Math.Round(shortageQuantityAverage / numOfDays, 2);
            Program.simulationTableForm.endingInventoryAvgTextBox.Text = endingInventoryAverage.ToString();
            Program.simulationTableForm.shortageQuantityAvgTextBox.Text = shortageQuantityAverage.ToString(); ;
            if (doAverage == true)
            {
                Program.mainForm.shortageAllTrialsAverage += this.shortageQuantityAverage;
                Program.mainForm.endingInventoryAllTrialsAverage += this.endingInventoryAverage;
                Program.mainForm.endingInventoryValues.Add(Convert.ToInt32(Math.Floor(endingInventoryAverage)));
            }
        }
    }
}