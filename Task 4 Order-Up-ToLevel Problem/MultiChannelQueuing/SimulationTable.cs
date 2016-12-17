using System;
using System.Windows.Forms;

namespace orderUpToLevelProblem
{
    public partial class SimulationTable : Form
    {
        public SimulationTable()
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
            (day.orderQuantity == 0) ? "-" : Convert.ToString(day.orderQuantity),
            (day.orderQuantity == 0) ? "-" : Convert.ToString(day.randomDigitsForDemand),
            (day.orderQuantity == 0) ? "-" : Convert.ToString(day.LeadTime),
            //Convert.ToString(day.daysUntilOrderArrives)
            (day.daysUntilOrderArrives == -1) ? "Arrived" : (day.daysUntilOrderArrives > -1) ? Convert.ToString(day.daysUntilOrderArrives)+" days" : "-"
           // Convert.ToString(day.shortageSoFar),
          //  Convert.ToString(day.alreadyOrdered)
            );
        }
        //(day.orderQuantity == -1) ? "-" : Convert.ToString(day.randomDigitsForDemand),
        private void CloseForm_Click(object sender, EventArgs e)
        {
            outputDataGrid.Rows.Clear();
            this.Dispose();
        }

        private void ViewChartsBTN_Click(object sender, EventArgs e)
        {
            Charts MainCharts = new Charts();
            MainCharts.Text = "Chart for " + Convert.ToString(Program.simulationTableForm.trialsComboBox.Text) + " Trials";
            MainCharts.Show();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {   
            for (int i = 0; i < Program.mainForm.simulation.numOfTrials; i++)
            {
                // Add the numbers of trails to the combo box (40,50,60...)
                Program.simulationTableForm.trialsComboBox.Items.Add(i+1);
            }
            trialsComboBox.SelectedIndex = 0;
            int size = Program.simulationTableForm.trialsComboBox.Items.Count;
            Program.mainForm.simulation.numOfDays = Convert.ToInt32(Program.mainForm.numOfDaysTextBox.Text);

            int daysCount = Program.mainForm.simulation.numOfDays;
            int trialsCount = Convert.ToInt32(Program.mainForm.numOfTrialsTextBox.Text);

            for (int i = size-1; i >=0 ; i--)
            {
                Program.simulationTableForm.outputDataGrid.Rows.Clear();
                Program.mainForm.simulation.LaunchSimulation(i,true);
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
