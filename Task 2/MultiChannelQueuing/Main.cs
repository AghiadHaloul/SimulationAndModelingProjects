using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public partial class Main : Form
    {
        public int simulationScale = 0;
        public InventorySystem simulation;
        
        static Random randomNumber = new Random();

        public int RandomProbability()
        {
            return randomNumber.Next(0, 100);
        }
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // Load some default values. Editable later.
            dayTypeDGV.Rows.Add(new string[] { "Good", "0.35" });
            dayTypeDGV.Rows.Add(new string[] { "Fair", "0.45" });
            dayTypeDGV.Rows.Add(new string[] { "Poor", "0.20" });

            DemandDGV.Rows.Add(new string[] { "40", "0.03", "0.10", "0.44" });
            DemandDGV.Rows.Add(new string[] { "50", "0.05", "0.18", "0.22" });
            DemandDGV.Rows.Add(new string[] { "60", "0.15", "0.40", "0.16" });
            DemandDGV.Rows.Add(new string[] { "70", "0.20", "0.20", "0.12" });
            DemandDGV.Rows.Add(new string[] { "80", "0.35", "0.08", "0.06" });
            DemandDGV.Rows.Add(new string[] { "90", "0.15", "0.04", "0.00" });
            DemandDGV.Rows.Add(new string[] { "100", "0.07", "0.00", "0.00" });


            simulation = new InventorySystem();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            simulation.SetPurchasedPapersCount(Convert.ToInt32(minPurchased.Text));
            simulation.SetPurchasingPrice(Convert.ToDouble(textBox1.Text));
            simulation.SetSellingPrice(Convert.ToDouble(textBox2.Text));
            simulation.SetScrapValue(Convert.ToDouble(textBox3.Text));
            // Calculate N random values and use them everytime we change the number pf purchased papers.
            for(int i=0;i<Convert.ToInt32(numOfDays.Text);i++)
            {
                simulation.dayTypeRandomValues.Add(RandomProbability());
                simulation.demandRandomValues.Add(RandomProbability());
            }
            Program.simulationTableForm.Show();
            button1.Enabled = false;

            //this.Hide();
        }
        public static void updateStats(string rev, string cost, string lost, string salvage, string net, string excess, string unsold, string solution)
        {

            Program.simulationTableForm.textBox4.Text = rev;
            Program.simulationTableForm.textBox5.Text = cost;
            Program.simulationTableForm.textBox6.Text = lost;
            Program.simulationTableForm.textBox1.Text = salvage;
            Program.simulationTableForm.textBox2.Text = net;
            Program.simulationTableForm.textBox3.Text = excess;
            Program.simulationTableForm.textBox7.Text = unsold;
            Program.simulationTableForm.textBox8.Text = solution;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            dayTypeDGV.Rows.Clear();
        }

        private void dayTypeDGV_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Add columns to demand table everytime a new row is added to day type.
            if (dayTypeDGV.Rows.Count > 1)
                DemandDGV.Columns.Add(dayTypeDGV.Rows[dayTypeDGV.Rows.Count - 2].Cells[0].Value.ToString(), dayTypeDGV.Rows[dayTypeDGV.Rows.Count - 2].Cells[0].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.NewTypeForm.Show();
        }        
    }
}
