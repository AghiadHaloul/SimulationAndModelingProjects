using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystemTask
{
    static class Program
    {
        public static mainForm mForm = new mainForm();
        public static SimulationTable simulationTableForm = new SimulationTable();
        public static ChartsForm MainCharts = new ChartsForm();
        public static Task1Simulation.AddType NewTypeForm = new Task1Simulation.AddType();
        // static Form1 mForm = new Form1();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {    
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mForm);
        }
    }
}
