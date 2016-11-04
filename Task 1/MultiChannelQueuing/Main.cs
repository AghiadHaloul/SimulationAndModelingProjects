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
            systemDGV.Rows.Add(new string[] { "1", "0.25" });
            systemDGV.Rows.Add(new string[] { "2", "0.40" });
            systemDGV.Rows.Add(new string[] { "3", "0.2" });
            systemDGV.Rows.Add(new string[] { "4", "0.15" });

            ServrersDataGridView.Rows.Add(new string[] { "2", "0.3" });
            ServrersDataGridView.Rows.Add(new string[] { "3", "0.28" });
            ServrersDataGridView.Rows.Add(new string[] { "4", "0.25" });
            ServrersDataGridView.Rows.Add(new string[] { "5", "0.17" });

            simulation = new QueuingSystem();
            comboBox1.SelectedIndex = 0;
            simulation.serverSelectionMode = 0;
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            if (systemDGV.Rows.Count <= 1)
            {
                MessageBox.Show("Please enter the system parameters before launching the simulation.");
                return;
            }
            if (Main.serversList.Count == 0)
            {
                MessageBox.Show("Please add at least one server."); return;
            }
            
            simulationScale = Convert.ToInt32(textBox1.Text);
            simulation.LaunchSimulation(Convert.ToInt32(textBox1.Text),serversList);
            
           Program.simulationTableForm.Show();
           button1.Enabled = false;
            //this.Hide();
        }
        public static void updateStats(string avgQueueTime, string maxQueue, string queueProb)
        {

            Program.simulationTableForm.textBox4.Text = avgQueueTime;
            Program.simulationTableForm.textBox5.Text = maxQueue;
            Program.simulationTableForm.textBox6.Text = queueProb;

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.theForm.ServrersDataGridView.Rows.Count <=1)
            {
                MessageBox.Show("Please enter the server's data before adding.");
                return;
            }
            
            Server tempServer = new Server();
            tempServer.SetServer();
            serversList.Add(tempServer);
            label7.Text = Convert.ToString(Convert.ToInt32(label7.Text) + 1);
            if(label7.Text=="1")
                button1.Text = "Start Simulation (" + label7.Text + " Server)";
            else
            button1.Text = "Start Simulation (" + label7.Text + " Servers)";

            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            simulation.serverSelectionMode = comboBox1.SelectedIndex;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ServrersDataGridView.Rows.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           systemDGV.Rows.Clear();
        }
    }
}
