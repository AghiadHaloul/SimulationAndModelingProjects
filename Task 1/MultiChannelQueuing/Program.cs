﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiChannelQueuing
{
    static class Program
    {
        public static Main theForm = new Main();
        public static SimulationTable simulationTableForm = new SimulationTable();
        public static Charts MainCharts = new Charts();
        // static Form1 theForm = new Form1();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(theForm);
        }
    }
}
