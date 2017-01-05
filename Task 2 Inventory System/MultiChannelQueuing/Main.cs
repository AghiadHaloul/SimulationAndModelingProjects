using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventorySystemTask
{
    public partial class mainForm : Form
    {
        public int simulationScale = 0;
        public InventorySystem simulation;

        static Random randomNumber = new Random();

        public int RandomProbability()
        {
            return randomNumber.Next(0, 100);
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // Load some default values. Editable later.
            dayTypeDataGridView.Rows.Add(new string[] { "Good", "0.35" });
            dayTypeDataGridView.Rows.Add(new string[] { "Fair", "0.45" });
            dayTypeDataGridView.Rows.Add(new string[] { "Poor", "0.20" });

            demandDataGridView.Rows.Add(new string[] { "40", "0.03", "0.10", "0.44" });
            demandDataGridView.Rows.Add(new string[] { "50", "0.05", "0.18", "0.22" });
            demandDataGridView.Rows.Add(new string[] { "60", "0.15", "0.40", "0.16" });
            demandDataGridView.Rows.Add(new string[] { "70", "0.20", "0.20", "0.12" });
            demandDataGridView.Rows.Add(new string[] { "80", "0.35", "0.08", "0.06" });
            demandDataGridView.Rows.Add(new string[] { "90", "0.15", "0.04", "0.00" });
            demandDataGridView.Rows.Add(new string[] { "100", "0.07", "0.00", "0.00" });


            simulation = new InventorySystem();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            simulation.SetPurchasedPapersCount(Convert.ToInt32(minPurchasedTextBox.Text));
            simulation.SetPurchasingPrice(Convert.ToDouble(purchasePriceTextBox.Text));
            simulation.SetSellingPrice(Convert.ToDouble(sellingPriceTextBox.Text));
            simulation.SetScrapValue(Convert.ToDouble(scrapValueTextBox.Text));
            // Calculate N random values and use them every time we change the number pf purchased papers.
            for (int i = 0; i < Convert.ToInt32(numOfDaysTextBox.Text); i++)
            {
                simulation.dayTypeRandomValues.Add(RandomProbability());
                simulation.demandRandomValues.Add(RandomProbability());
            }
            Program.simulationTableForm.Show();
            startSimulationButton.Enabled = false;
        }

        public static void updateStats(string rev, string cost, string lost, string salvage, string net, string excess, string unsold, string solution)
        {
            Program.simulationTableForm.revnueTextBox.Text = rev;
            Program.simulationTableForm.costOfNewspaperTextBox.Text = cost;
            Program.simulationTableForm.lostProfitTextBox.Text = lost;
            Program.simulationTableForm.salvageTextBox.Text = salvage;
            Program.simulationTableForm.NetProfitTextBox.Text = net;
            Program.simulationTableForm.excessDemandTextBox.Text = excess;
            Program.simulationTableForm.unsoldPapersTextBox.Text = unsold;
            Program.simulationTableForm.optimalNumberTextBox.Text = solution;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dayTypeDataGridView.Rows.Clear();
        }

        private void dayTypeDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Add columns to demand table every time a new row is added to day type.
            if (dayTypeDataGridView.Rows.Count > 1)
                demandDataGridView.Columns.Add(dayTypeDataGridView.Rows[dayTypeDataGridView.Rows.Count - 2].Cells[0].Value.ToString(), dayTypeDataGridView.Rows[dayTypeDataGridView.Rows.Count - 2].Cells[0].Value.ToString());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Program.NewTypeForm.Show();
        }
    }
}