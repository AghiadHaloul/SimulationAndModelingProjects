using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    public partial class Main : Form
    {
        public int simulationScale = 0;
        public static List<Server> serversList = new List<Server>();
        public QueuingSystem simulation;


        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // Just to load some default values .. They will be editable ..
            systemDataGridView.Rows.Add(new string[] { "1", "0.25" });
            systemDataGridView.Rows.Add(new string[] { "2", "0.40" });
            systemDataGridView.Rows.Add(new string[] { "3", "0.2" });
            systemDataGridView.Rows.Add(new string[] { "4", "0.15" });

            servrersDataGridView.Rows.Add(new string[] { "2", "0.3" });
            servrersDataGridView.Rows.Add(new string[] { "3", "0.28" });
            servrersDataGridView.Rows.Add(new string[] { "4", "0.25" });
            servrersDataGridView.Rows.Add(new string[] { "5", "0.17" });

            simulation = new QueuingSystem();
            selectionMethodComboBox.SelectedIndex = 0;
            simulation.serverSelectionMode = 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (systemDataGridView.Rows.Count <= 1)
            {
                MessageBox.Show("Please enter the system parameters before launching the simulation.");
                return;
            }
            if (Main.serversList.Count == 0)
            {
                MessageBox.Show("Please add at least one server."); return;
            }

            simulationScale = Convert.ToInt32(numberOfCustomersTextBox.Text);
            simulation.LaunchSimulation(Convert.ToInt32(numberOfCustomersTextBox.Text), serversList);

            Program.simulationTableForm.Show();
            startSimulationButton.Enabled = false;
            //this.Hide();
        }
        public static void updateStats(string avgQueueTime, string maxQueue, string queueProb)
        {

            Program.simulationTableForm.avgQueueWaitTextBox.Text = avgQueueTime;
            Program.simulationTableForm.maxQueueLengthTextBox.Text = maxQueue;
            Program.simulationTableForm.probOfQueueTextBox.Text = queueProb;

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.mainForm.servrersDataGridView.Rows.Count <= 1)
            {
                MessageBox.Show("Please enter the server's data before adding.");
                return;
            }

            Server tempServer = new Server();
            tempServer.SetServer();
            serversList.Add(tempServer);
            label7.Text = Convert.ToString(Convert.ToInt32(label7.Text) + 1);
            if (label7.Text == "1")
                startSimulationButton.Text = "Start Simulation (" + label7.Text + " Server)";
            else
                startSimulationButton.Text = "Start Simulation (" + label7.Text + " Servers)";


        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectionMethodComboBox.SelectedIndex)
            {
                case 0:
                    simulation.serverSelectionMode = QueuingSystem.ServerSelectionMode.highestPriority;
                    break;
                case 1:
                    simulation.serverSelectionMode = QueuingSystem.ServerSelectionMode.random;
                    break;
                case 2:
                    simulation.serverSelectionMode = QueuingSystem.ServerSelectionMode.leastUtilization;
                    break;
                default:
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            servrersDataGridView.Rows.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            systemDataGridView.Rows.Clear();
        }
    }
}
