using System;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public partial class SimulationTable : Form
    {
        public SimulationTable()
        {
            InitializeComponent();
        }
        
        public static void addToOutput(DataGridView gridName ,Day day)
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
            Charts MainCharts = new Charts();
            MainCharts.Text = "Chart for "+Convert.ToString(Program.simulationTableForm.comboBox1.Text)+" Papers";
            MainCharts.Show();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            for (int i = Convert.ToInt32(Program.theForm.minPurchased.Text); i <= Convert.ToInt32(Program.theForm.textBox5.Text); i += 10)
            {
                // Add numbers of papers to the combo box (40,50,60...)
                Program.simulationTableForm.comboBox1.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            // Launch the simulation for all the values in the combobox to find the optimal answer.
            for (int i = 0; i < Program.simulationTableForm.comboBox1.Items.Count; i++)
            {
                Program.theForm.simulation.SetPurchasedPapersCount(Convert.ToInt32(Program.simulationTableForm.comboBox1.Items[i]));
                Program.theForm.simulation.LaunchSimulation(Convert.ToInt32(Program.theForm.numOfDays.Text));
                Program.simulationTableForm.outputDataGrid.Rows.Clear();
            }
            Program.theForm.simulation.LaunchSimulation(Convert.ToInt32(Program.theForm.numOfDays.Text));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.simulationTableForm.outputDataGrid.Rows.Clear();
            Program.theForm.simulation.SetPurchasedPapersCount(Convert.ToInt32(Program.simulationTableForm.comboBox1.Text));
            Program.theForm.simulation.LaunchSimulation(Convert.ToInt32(Program.theForm.numOfDays.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

    }
}
