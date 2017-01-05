using System;
using System.Windows.Forms;
using System.Threading;

namespace orderUpToLevelProblem
{
    public partial class SimulationTableForm : Form
    {
        public SimulationTableForm()
        {
            InitializeComponent();
        }
        public static void AddToOutput(DataGridView gridName, Day day)
        {
            gridName.Rows.Add(
            Convert.ToString(day.id),
            Convert.ToString(day.cycle),
            Convert.ToString(day.dayWithinCycle),
            Convert.ToString(day.beginningInventory),
            Convert.ToString(day.randomDigitsForDemand),
            Convert.ToString(day.demand),
            Convert.ToString(day.endingInventory),
            Convert.ToString(day.shortageQuantity),
            (day.LeadTime == 0) ? "-" : Convert.ToString(day.orderQuantity),
            (day.LeadTime == 0) ? "-" : Convert.ToString(day.randomDigitsForLeadTime),
            (day.LeadTime == 0) ? "-" : Convert.ToString(day.LeadTime),
            (day.daysUntilOrderArrives == 0) ? "Next day" : (day.daysUntilOrderArrives == -1) ? "Arrived" : (day.daysUntilOrderArrives < -1) ? "-" : (day.daysUntilOrderArrives == 1) ? Convert.ToString(day.daysUntilOrderArrives) + " day" : Convert.ToString(day.daysUntilOrderArrives) + " days"
            );
        }
        private void CloseForm_Click(object sender, EventArgs e)
        {
            outputDataGrid.Rows.Clear();
            this.Dispose();
        }

        private void ViewChartsBTN_Click(object sender, EventArgs e)
        {
            ChartsForm MainCharts = new ChartsForm();
            MainCharts.Show();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {   
            for (int i = 0; i < Program.mainForm.simulation.numOfTrials; i++)
            {
                // Add the numbers of trails to the comboBox (40,50,60...)
                Program.simulationTableForm.trialsComboBox.Items.Add(i+1);
            }
            trialsComboBox.SelectedIndex = 0;
            int size = Program.simulationTableForm.trialsComboBox.Items.Count;
            Program.mainForm.simulation.numOfDays = Convert.ToInt32(Program.mainForm.numOfDaysNumericUpDown.Text);

            int daysCount = Program.mainForm.simulation.numOfDays;
            int trialsCount = Convert.ToInt32(Program.mainForm.numOfDaysNumericUpDown.Text);
            for (int i = size - 1; i >= 0; i--)
            {
                Program.simulationTableForm.outputDataGrid.Rows.Clear();
                Program.mainForm.simulation.LaunchSimulation(i, true);
            }
            for (int i = 0; i < outputDataGrid.Columns.Count; i++)
            {
                outputDataGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            Program.mainForm.shortageAllTrialsAverage = Math.Round(Program.mainForm.shortageAllTrialsAverage / size, 2);
            Program.mainForm.endingInventoryAllTrialsAverage = Math.Round(Program.mainForm.endingInventoryAllTrialsAverage / size, 2);
            
            Program.simulationTableForm.shortageQuantityAverageAllTextBox.Text = Program.mainForm.shortageAllTrialsAverage.ToString();
            Program.simulationTableForm.endingInventoryAverageAllTextBox.Text = Program.mainForm.endingInventoryAllTrialsAverage.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.simulationTableForm.outputDataGrid.Rows.Clear();
            Program.mainForm.simulation.LaunchSimulation(Convert.ToInt32(trialsComboBox.Text)-1,false);
        }
        private void SimulationTable_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.mainForm.Dispose();
        }
    }
}
