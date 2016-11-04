using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace MultiChannelQueuing
{
    public partial class Charts : Form
    {
        public Charts(){InitializeComponent();}

        private void Charts_Load(object sender, EventArgs e)
        {
            List<Tuple<double, int>> points = new List<Tuple<double,int>>();
            // <$0.00,5>
            // <$0.50,10>
            // <$1.50,20>
            // <xValue, yValue>

            for (int i = 0; i < Program.theForm.simulation.daysList.Count ;i++)
            { // Fill the list with points
                bool found=false;
                for(int j=0;j<points.Count;j++)
                {
                    if (points[j].Item1 == Program.theForm.simulation.daysList[i].GetProfitD())
                    {
                        Tuple<double, int> T = new Tuple<double, int>(points[j].Item1, points[j].Item2 + 1);
                        points[j] = T;
                        found=true;
                    }
                }
                if(found==false)
                {
                    points.Add(new Tuple<double, int>(Program.theForm.simulation.daysList[i].GetProfitD(), 1));
                }
            }
            points.Sort();
            for (int i = 0; i < points.Count;i++)
            {
                // Add point value.
                chart1.Series["ColumnChart"].Points.AddY(points[i].Item2);
                // Add a label to the column.
                chart1.Series["ColumnChart"].Points[i].AxisLabel = points[i].Item1.ToString("$0.00");
            }
            // Add axis titles.
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Revenue ($)";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Count of Repetition (Days)";
            
        }



    }
}