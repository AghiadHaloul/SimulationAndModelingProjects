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

            simulation = new QueuingSystem();
            comboBox1.SelectedIndex = 0;
            simulation.serverSelectionMode = 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (Main.serversList.Count == 0)
            {
                MessageBox.Show("Please add at least one server."); return;
            }
            if (systemBetaTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please add beta value for system."); return;
            }

            QueuingSystem.beta = Double.Parse(systemBetaTextBox.Text);
            simulationScale = Convert.ToInt32(textBox1.Text);
            simulation.LaunchSimulation(Convert.ToInt32(textBox1.Text), serversList);

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
            if (serverBetaTxtBox.Text.Length == 0) return;
            double beta = Double.Parse(serverBetaTxtBox.Text);
            Server tempServer = new Server(beta);
            serversList.Add(tempServer);
            label7.Text = Convert.ToString(Convert.ToInt32(label7.Text) + 1);
            if (label7.Text == "1")
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

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
