using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
namespace orderUpToLevelProblem
{
    public partial class Main : Form
    {
        public int simulationScale = 0;
        public RefrigeratorInventorySystem simulation;
        public double endingInventoryAllTrialsAverage;
        public double shortageAllTrialsAverage;
        public List<int> endingInventoryValues = new List<int>();
        static Random randomNumber = new Random();
        public void ClearAllAverages()
        {
            endingInventoryAllTrialsAverage = 0;
            shortageAllTrialsAverage = 0;        
        }
        public int RandomProbability()
        {
            return randomNumber.Next(0, 100);
        }
        public Main()
        {
            InitializeComponent();
        }
        public void generatePseduRandomValues(int i, int daysCount, List<int> trialIDemand, List<int> trialILeadTime)
        {
            int a = Convert.ToInt32(Program.mainForm.aValueNumericUpDown.Text);
            int c = Convert.ToInt32(Program.mainForm.cValueNumericUpDown.Text);
            int m = Convert.ToInt32(Program.mainForm.mValueNumericUpDown.Text);
            int zm1 = i;//seed
            int z;
            for (int j = 0; j < daysCount; j++)
            {
                z = (a * zm1 + c) % m;
                trialIDemand.Add(z);
                zm1 = z;
            }

            for (int j = 0; j < daysCount; j++)
            {
                z = (a * zm1 + c) % m;
                trialILeadTime.Add(z);
                zm1 = z;
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // Load some default values. Editable later.
            demandDataGridView.Rows.Add(new string[] { "0", "0.10" });
            demandDataGridView.Rows.Add(new string[] { "1", "0.25" });
            demandDataGridView.Rows.Add(new string[] { "2", "0.35" });
            demandDataGridView.Rows.Add(new string[] { "3", "0.21" });
            demandDataGridView.Rows.Add(new string[] { "4", "0.09" });
            leadTimeDataGridView.Rows.Add(new string[] { "1", "0.6" });
            leadTimeDataGridView.Rows.Add(new string[] { "2", "0.3" });
            leadTimeDataGridView.Rows.Add(new string[] { "3", "0.1" });
            simulation = new RefrigeratorInventorySystem();
        }
        public bool validateProbabilities()
        {
            double probSum = 0;

            for (int i = 0; i < leadTimeDataGridView.Rows.Count-1; i++)
            {
                probSum += Math.Round(Convert.ToDouble(leadTimeDataGridView.Rows[i].Cells[1].Value),5);
                if(Convert.ToInt32(leadTimeDataGridView.Rows[i].Cells[0].Value)>=simulation.reviewPeriod)
                {
                    MessageBox.Show("Lead time (" + leadTimeDataGridView.Rows[i].Cells[0].Value.ToString() + ") can't be greater than the review period (" + simulation.reviewPeriod.ToString() + ").");
                    return false;
                }
            }
            if (Math.Round(probSum,5) != 1)
            {
                MessageBox.Show("The summation of the entered lead time probabilities must equal 1. Please check the entered values." + " Current sum = "+probSum.ToString()+".");
                return false;
            }

            probSum = 0;
            for (int i = 0; i < demandDataGridView.Rows.Count-1; i++)
            {
                probSum += Math.Round(Convert.ToDouble(demandDataGridView.Rows[i].Cells[1].Value),5);
            }
            if (Math.Round(probSum, 5) != 1)
            {
                MessageBox.Show("The summation of the entered demand probabilities must equal 1. Please check the entered values." + " Current sum = " + probSum.ToString()+".");
                return false;
            }
            return true;
        }
        public bool validateTextBoxes()
        {
            if (Program.mainForm.numOfTrialsNumericUpDown.Text == "")
            {
                MessageBox.Show("Number of trials can't be empty.");
                return false;
            }
            if (Program.mainForm.reviewPeriodNumericUpDown.Text == "")
            {
                MessageBox.Show("Number of trials can't be empty.");
                return false;
            }
            if (Program.mainForm.orderUpToLevelNumericUpDown.Text == "")
            {
                MessageBox.Show("Number of trials can't be empty.");
                return false;
            }
            return true;
        }
        private void startSimulationButton_Click(object sender, EventArgs e)
        {
                Thread.CurrentThread.IsBackground = true;
                if (validateTextBoxes() == false) return;
                ClearAllAverages();
                simulation.setDemandProbability();
                simulation.setLeadProbability();
                Program.mainForm.simulation.numOfTrials = Convert.ToInt32(Program.mainForm.numOfDaysNumericUpDown.Text);
                Program.mainForm.simulation.reviewPeriod = Convert.ToInt32(Program.mainForm.reviewPeriodNumericUpDown.Text);
                Program.mainForm.simulation.OrderUpToLevel = Convert.ToInt32(Program.mainForm.orderUpToLevelNumericUpDown.Text);
                if (validateProbabilities() == false)
                {
                    return;
                }
                int daysCount = Convert.ToInt32(numOfDaysNumericUpDown.Text);
                int trialsCount = Convert.ToInt32(numOfTrialsNumericUpDown.Text);
                // Calculate N random values and use them at each trial.
                for (int i = 0; i < trialsCount; i++)
                {
                    List<int> trialIDemand = new List<int>();
                    List<int> trialILeadTime = new List<int>();
                    generatePseduRandomValues(i, daysCount, trialIDemand, trialILeadTime);
                    Program.mainForm.simulation.demandPerDayRandomValues.Add(trialIDemand);
                    Program.mainForm.simulation.leadTimeRandomValues.Add(trialILeadTime);
                }
                Program.simulationTableForm.Show();
        }

        private void clearLeadButton_Click(object sender, EventArgs e)
        {
            leadTimeDataGridView.Rows.Clear();
        }

        private void clearDemandButton_Click(object sender, EventArgs e)
        {
            demandDataGridView.Rows.Clear();
        }
    }
}