using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderUpToLevelProblem
{
    static class Program
    {
        public static Main mainForm = new Main();
        public static SimulationTableForm simulationTableForm = new SimulationTableForm();
        public static ChartsForm MainCharts = new ChartsForm();
        // static Form1 mainForm = new Form1();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {    
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);
        }   
    }
}
