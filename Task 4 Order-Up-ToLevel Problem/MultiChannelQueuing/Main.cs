using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            int a = Convert.ToInt32(Program.mainForm.aValueTextBox.Text);
            int c = Convert.ToInt32(Program.mainForm.cValueTextBox.Text);
            int m = Convert.ToInt32(Program.mainForm.mValueTextBox.Text);
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
        private void startSimulationButton_Click(object sender, EventArgs e)
        {
            ClearAllAverages();
            simulation.setDemandProbability();
            simulation.setLeadProbability();
            Program.mainForm.simulation.numOfTrials = Convert.ToInt32(Program.mainForm.numOfTrialsTextBox.Text);
            Program.mainForm.simulation.reviewPeriod = Convert.ToInt32(Program.mainForm.reviewPeriodTextBox.Text);
            Program.mainForm.simulation.OrderUpToLevel = Convert.ToInt32(Program.mainForm.orderUpToLevelTextBox.Text);
            int daysCount = Convert.ToInt32(numOfDaysTextBox.Text);
            int trialsCount = Convert.ToInt32(numOfTrialsTextBox.Text);
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
    }
}