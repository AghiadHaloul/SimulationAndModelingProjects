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
        
        public static void addToOutput(DataGridView gridName ,Customer customer)
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
        public static void addToOutput(DataGridView gridName ,String ID,String val)
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
            //TODO: Implement the charting module using ZedGraph or the standard C# charting library.
        }

        private void SimulationTable_Load(object sender, EventArgs e)
        {
            label1.Text += Program.theForm.simulationScale.ToString() + " \ncustomers";
        }

    }
}
