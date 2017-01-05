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

        public static void AddToOutput(DataGridView gridName, Customer customer)
        {
            gridName.Rows.Add(
            Convert.ToString(customer.GetID()),
            Convert.ToString(customer.GetInterArrivalProbability()),
            Convert.ToString(customer.GetInterArrivalTime()),
            Convert.ToString(customer.GetArrivalTime()),
            Convert.ToString(customer.GetServerIndex()),
            Convert.ToString(customer.GetServiceBegin()),
            Convert.ToString(customer.GetServiceDurationProbaility()),
            Convert.ToString(customer.GetServiceDuration()),
            Convert.ToString(customer.GetServiceEnd()),
            Convert.ToString(customer.GetDelay()));
        }
        public static void AddToOutput(DataGridView gridName, String ID, String val)
        {
            gridName.Rows.Add(ID, val);
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            outputDataGrid.Rows.Clear();
            this.Dispose();

        }

        private void ViewChartsBTN_Click(object sender, EventArgs e)
        {
            Program.MainCharts.Show();
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            resultsLabel.Text += Program.mainForm.simulationScale.ToString() + " \ncustomers";
        }

    }
}
