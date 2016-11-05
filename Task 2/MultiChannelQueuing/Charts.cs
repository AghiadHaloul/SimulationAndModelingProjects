using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using System.Windows.Forms.DataVisualization.Charting;

namespace MultiChannelQueuing
{
    public partial class Charts : Form
    {
        public Charts(){InitializeComponent();}

        private void Charts_Load(object sender, EventArgs e)
        {

            loadChart();
        }
        void loadChart()
        {
            List<Tuple<double, int>> points = new List<Tuple<double, int>>();
            List<Tuple<double, double, int>> ranges = new List<Tuple<double, double, int>>();
            // <$0.00,5>
            // <$0.50,10>
            // <$1.50,20>
            // <xValue, yValue>
            int numOfRanges = Convert.ToInt32(numericUpDown1.Text);
            for (int i = 0; i < Program.theForm.simulation.daysList.Count; i++)
            { // Fill the list with points
                bool found = false;
                for (int j = 0; j < points.Count; j++)
                {
                    if (points[j].Item1 == Program.theForm.simulation.daysList[i].GetProfitD())
                    {
                        Tuple<double, int> T = new Tuple<double, int>(points[j].Item1, points[j].Item2 + 1);
                        points[j] = T;
                        found = true;
                    }
                }
                if (found == false)
                {
                    points.Add(new Tuple<double, int>(Program.theForm.simulation.daysList[i].GetProfitD(), 1));       
                }
            }
            points.Sort();
            MessageBox.Show(points.Count.ToString());
            double stepSize = (Math.Abs(points[0].Item1) + Math.Abs(points[points.Count - 1].Item1)) / numOfRanges;
            for (int i = 0; i < numOfRanges; i++)
            {
                if (i == 0 && i != numOfRanges - 1)
                {
                    ranges.Add(new Tuple<double, double, int>(points[0].Item1, points[0].Item1 + stepSize-0.01, 0));
                }
                else if (i == numOfRanges-1 && i!=0)
                {
                    ranges.Add(new Tuple<double, double, int>(ranges[i - 1].Item2+0.01, ranges[i - 1].Item2 + stepSize+0.01, 0));
                }
                else if (i == numOfRanges - 1 && i == 0)
                {
                    ranges.Add(new Tuple<double, double, int>(points[0].Item1, points[points.Count - 1].Item1, 0));
                }
                else
                {
                    ranges.Add(new Tuple<double, double, int>(ranges[i - 1].Item2+0.01, ranges[i - 1].Item2 + stepSize, 0));
                }
            }
            int k=0;
            for (int i = 0; i < points.Count;)
            {
                if (points[i].Item1 >= ranges[k].Item1 && points[i].Item1 < ranges[k].Item2)
                {
                    Tuple<double,double, int> T = new Tuple<double, double, int>(ranges[k].Item1, ranges[k].Item2, ranges[k].Item3 + points[i].Item2);
                    ranges[k] = T;
                    i++;
                }
                else
                {   
                    if(i==points.Count-1)
                    {
                        if (points[i].Item1 < ranges[k].Item1 || points[i].Item1 > ranges[k].Item2)
                            k++;
                        Tuple<double, double, int> T = new Tuple<double, double, int>(ranges[k].Item1, ranges[k].Item2, ranges[k].Item3 + points[i].Item2);
                        ranges[k] = T;
                        i++;
                    }
                    else
                    {
                        k++;
                    }   
                }
            }

            for (int i = 0, j = 0; i < ranges.Count; i++,j++)
            {
            if(numOfRanges>points.Count)
            {
                int x = 0;
                x++;

            }
                // Add point value.
                chart1.Series["ColumnChart"].Points.AddY(ranges[i].Item3);
                // Add a label to the column.
                chart1.Series["ColumnChart"].Points[j].AxisLabel =  ranges[i].Item1.ToString("$0.00") + " to " + (ranges[i].Item2).ToString("$0.00");
                // Add point value.
               // int t = 0;
                //int k;
                //for (k = i; k < i+(Math.Round(Convert.ToDouble(points.Count) / numOfRanges)) && k<points.Count; k++)
                //{
            
                  //  t += points[k].Item2;
                //}
                //chart1.Series["ColumnChart"].Points.AddY(t);
                // Add a label to the column.
                //chart1.Series["ColumnChart"].Points[j].AxisLabel = points[i].Item1.ToString("$0.00") + " to " + points[k - 1].Item1.ToString("$0.00");
                //j++;
                //i = k;

                // Add a label to the column.

            }
            
            // Add axis titles.
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Revenue ($)";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Count of Repetition (Days)";
        }
        private void pie_CheckedChanged(object sender, EventArgs e)
        {

            if (chart1.Series["ColumnChart"].ChartType == SeriesChartType.Pie)
                chart1.Series["ColumnChart"].ChartType = SeriesChartType.Column;
            else
                chart1.Series["ColumnChart"].ChartType = SeriesChartType.Pie;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series["ColumnChart"].Points.Clear();
            loadChart();
        }

        



    }
}