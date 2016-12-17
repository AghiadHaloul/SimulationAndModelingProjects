using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;
using System.Windows.Forms.DataVisualization.Charting;

namespace orderUpToLevelProblem
{
    public partial class Charts : Form
    {
        public Charts() { InitializeComponent(); }

        private void Charts_Load(object sender, EventArgs e)
        {

            loadChart();
        }
        public List<Tuple<double, int>> CalcPointsSeries(List<int> dataSource)
        {
            List<Tuple<double, int>> points = new List<Tuple<double, int>>();
            // <1 Refrigerator,5>
            // <4 Refrigerators,10>
            // <7 Refrigerators,20>
            // <xValue, yValue>

            for (int i = 0; i < dataSource.Count; i++)
            {
                bool found = false;
                for (int j = 0; j < points.Count; j++)//If value exists already, increment, else add to list;
                {
                    if (points[j].Item1 == dataSource[i])
                    {
                        Tuple<double, int> T = new Tuple<double, int>(points[j].Item1, points[j].Item2 + 1);
                        points[j] = T;
                        found = true;
                    }
                }
                if (found == false)
                {
                    points.Add(new Tuple<double, int>(dataSource[i], 1));
                }
            }
            points.Sort();
            return points;
        }
        public void loadPointsToChart(List<Tuple<double, int>> points)
        {
            
            for (int i = 0, j = 0; i < points.Count; i++)
            {
                // Add point value.
                chart1.Series["ColumnChart"].Points.AddY(points[i].Item2);
                // Add a label to the column.
                chart1.Series["ColumnChart"].Points[j++].AxisLabel = points[i].Item1.ToString("0 Units");
            }
            // Add axis titles.
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Ending Inventory Value (Units)";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Count of Repetition (Days)";
        }

        void loadChart()
        {
            List<int> input = Program.mainForm.endingInventoryValues;
            loadPointsToChart(CalcPointsSeries(input));
        }
        private void pie_CheckedChanged(object sender, EventArgs e)
        {
            if (chart1.Series["ColumnChart"].ChartType == SeriesChartType.Pie)
                chart1.Series["ColumnChart"].ChartType = SeriesChartType.Column;
            else
                chart1.Series["ColumnChart"].ChartType = SeriesChartType.Pie;
        }
    }
}