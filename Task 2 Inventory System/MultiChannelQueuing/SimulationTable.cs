using System;
using System.Windows.Forms;

namespace InventorySystemTask
{
    public partial class SimulationTable : Form
    {
        public SimulationTable()
        {
            InitializeComponent();
        }

        public static void addToOutput(DataGridView gridName, Day day)
        {
            gridName.Rows.Add(
            Convert.ToString(day.GetID()),
            Convert.ToString(day.GetTypeRandomDigits()),
            day.GetType(),
            Convert.ToString(day.GetDemandRandomDigits()),
            Convert.ToString(day.GetDemand()),
            Convert.ToString(day.GetRevenueFromSales()),
            Convert.ToString(day.GetLostProfit()),
            Convert.ToString(day.GetSalvageOfScrap()),
            Convert.ToString(day.GetProfit()));
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            outputDataGrid.Rows.Clear();
            this.Dispose();
        }

        private void ViewChartsBTN_Click(object sender, EventArgs e)
        {
            ChartsForm MainCharts = new ChartsForm();
            MainCharts.Text = "Chart for " + Convert.ToString(Program.simulationTableForm.purchasedPapersComboBox.Text) + " Papers";
            MainCharts.Show();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            int minPurchased = Convert.ToInt32(Program.mForm.minPurchasedTextBox.Text),
                maxPurchased = Convert.ToInt32(Program.mForm.maxPurchasedTextBox.Text);
            for (int i = minPurchased; i <= maxPurchased; i += 10)
            {
                // Add numbers of papers to the combo box (40,50,60...)
                Program.simulationTableForm.purchasedPapersComboBox.Items.Add(i);
            }
            purchasedPapersComboBox.SelectedIndex = 0;
            int size = Program.simulationTableForm.purchasedPapersComboBox.Items.Count;
            // Launch the simulation for all the values in the combobox to find the optimal answer.
            for (int i = size - 1; i >= 0; i--)
            {
                Program.mForm.simulation.SetPurchasedPapersCount(Convert.ToInt32(Program.simulationTableForm.purchasedPapersComboBox.Items[i]));
                Program.mForm.simulation.LaunchSimulation(Convert.ToInt32(Program.mForm.numOfDaysTextBox.Text));
                if (i != 0) Program.simulationTableForm.outputDataGrid.Rows.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.simulationTableForm.outputDataGrid.Rows.Clear();
            Program.mForm.simulation.SetPurchasedPapersCount(Convert.ToInt32(Program.simulationTableForm.purchasedPapersComboBox.Text));
            Program.mForm.simulation.LaunchSimulation(Convert.ToInt32(Program.mForm.numOfDaysTextBox.Text));
        }
    }
}
