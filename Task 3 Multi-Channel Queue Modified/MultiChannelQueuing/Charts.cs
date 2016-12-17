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

        private void LoadCustomerQueueGraph()
        {
            // For Customers Queue Graph .. 
            CustomerQueueGraphPanel.Invalidate();
            CustomerQueueGraphPanel.GraphPane.CurveList.Clear();
            CustomerQueueGraphPanel.GraphPane.GraphObjList.Clear();

            // -- Begin Plotting .. 

            List<double> xDataCustomerQueueGraph = new List<double>();
            List<double> yDataCustomerQueueGraph = new List<double>();

            int MaxGraphValueQueueGraph = QueuingSystem.queueArray.Length;

            GraphPane CustomerQueueGraphPane = CustomerQueueGraphPanel.GraphPane;

            // Set the Titles
            CustomerQueueGraphPane.Title.Text = "Customers Queue Graph";
            CustomerQueueGraphPane.XAxis.Title.Text = "Hours";
            CustomerQueueGraphPane.YAxis.Title.Text = "Numbers Of Customers";

            CustomerQueueGraphPane.XAxis.Scale.Min = 0;
            CustomerQueueGraphPane.YAxis.Scale.Min = 0;

            CustomerQueueGraphPane.XAxis.Scale.Max = MaxGraphValueQueueGraph;
            
            // Getting the maximum value for the queue size ..  
            CustomerQueueGraphPane.YAxis.Scale.Max = Convert.ToInt32(Program.simulationTableForm.textBox5.Text);

            CustomerQueueGraphPane.YAxis.Scale.MajorStep = 1;

            CustomerQueueGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            CustomerQueueGraphPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            int UnitSize = 1;

            for (int i = 0; i < QueuingSystem.queueArray.Length; i++)
            {
                if (QueuingSystem.queueArray[i] != 0)
                {
                    BoxObj box = new BoxObj(i, (int)QueuingSystem.queueArray[i], UnitSize, (int)QueuingSystem.queueArray[i], Color.Empty, Color.Red);
                    box.IsVisible = true;
                    box.Location.CoordinateFrame = CoordType.AxisXYScale;
                    box.ZOrder = ZOrder.A_InFront;
                    CustomerQueueGraphPanel.GraphPane.GraphObjList.Add(box);
                }
            }

            // Tell ZedGraph to refigure the
            // axes since the data have changed

            CustomerQueueGraphPane.AxisChange();
            CustomerQueueGraphPanel.Invalidate();
            // -- End Plotting 
        }

        private void LoadQueueHistogramGraph()
        {
            //// For Histogram .. 

            //// -- Begin Plotting .. 
            List<double> xDataQueueHisto = new List<double>();
            List<double> yDataQueueHisto = new List<double>();

            int MaxGraphQueueHisto = 0;

            GraphPane QueueHistoGraphPane = QueueSizeHistogramPanel.GraphPane;

            // Set the Titles
            QueueHistoGraphPane.Title.Text = "Queue Size Histogram";
            QueueHistoGraphPane.XAxis.Title.Text = "Delay Value";
            QueueHistoGraphPane.YAxis.Title.Text = "Numbers Of Customers";

            QueueHistoGraphPane.XAxis.Scale.Min = -1;
            QueueHistoGraphPane.YAxis.Scale.Min = 0;

            //QueueHistoGraphPane.XAxis.Scale.MajorStep = 0.1;
            //QueueHistoGraphPane.YAxis.Scale.MajorStep = 0.1;
            

            DataGridView HistoData = Program.simulationTableForm.outputDataGrid;
            Dictionary<double,int> HistoList = new Dictionary<double, int>();

            double MaxHisto = 0;

            for (int i = 0; i < HistoData.Rows.Count; i++)
            {
                if (!HistoList.ContainsKey(Convert.ToDouble(HistoData.Rows[i].Cells[9].Value)))
                {
                    HistoList.Add(Convert.ToDouble(HistoData.Rows[i].Cells[9].Value), 0);
                }
                HistoList[Convert.ToDouble(HistoData.Rows[i].Cells[9].Value)]++;
                if (HistoList[Convert.ToDouble(HistoData.Rows[i].Cells[9].Value)] >= MaxHisto) MaxHisto = (int)HistoList[Convert.ToDouble(HistoData.Rows[i].Cells[9].Value)];
            }
            QueueHistoGraphPane.XAxis.Scale.Max = HistoList.Count;
            QueueHistoGraphPane.YAxis.Scale.Max = Convert.ToInt32(MaxHisto);

            QueueHistoGraphPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            QueueHistoGraphPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            int idx = 0;
            double[] xAxisForQueueHisto = new double[HistoList.Count];
            double[] yAxisForQueueHisto = new double[HistoList.Count];
            foreach (KeyValuePair<double, int> v in HistoList)
            {
                xAxisForQueueHisto[idx] = v.Key;
                yAxisForQueueHisto[idx++] = v.Value;
            }

            BarItem b = QueueHistoGraphPane.AddBar("", xAxisForQueueHisto, yAxisForQueueHisto, Color.Red);

            QueueHistoGraphPane.AxisChange();
            QueueSizeHistogramPanel.Invalidate();
            //// -- End Plotting 
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            // Loading the first chart ..
            ServerBusyChartPanel.Invalidate();
            ServerBusyChartPanel.GraphPane.CurveList.Clear();
            ServerBusyChartPanel.GraphPane.GraphObjList.Clear();

            for (int i = 0; i < Server.counter; i++) { IDs.Items.Add(i); }

            // -- Begin Plotting .. //////////////////
            List<double> xData = new List<double>();
            List<double> yData = new List<double>();

            DataGridView data = Program.simulationTableForm.outputDataGrid;

            // We want the max length of the X axis, it can be the maximum value of end service (the end service of the last customer) 
            double MaxGraphValue = Convert.ToDouble(Program.simulationTableForm.outputDataGrid.Rows[Program.simulationTableForm.outputDataGrid.Rows.Count - 1].Cells[8].Value);

            GraphPane myPane = ServerBusyChartPanel.GraphPane;

            // Set the Pane Title
            myPane.Title.Text = "Server Busy Time for Server #0";
            myPane.XAxis.Title.Text = "Busy Time In Hours";
            myPane.YAxis.Title.Text = "Occurrence";

            myPane.XAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Min = 0;

            myPane.XAxis.Scale.Max = MaxGraphValue;
            myPane.YAxis.Scale.Max = MaxGraphValue; // We don't care for the Y axis, but we need to do that to expand the chart
            
            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i].Cells[4].Value.ToString() == "0")
                {
                    // Eventually :@  .. 
                    double begin = Convert.ToDouble(data.Rows[i].Cells[5].Value);
                    double end = Convert.ToDouble(data.Rows[i].Cells[8].Value);

                    BoxObj box = new BoxObj(begin, MaxGraphValue / 4, end - begin, MaxGraphValue / 4, Color.Empty, Color.Red);
                    box.IsVisible = true;
                    box.Location.CoordinateFrame = CoordType.AxisXYScale;
                    box.ZOrder = ZOrder.A_InFront;
                    ServerBusyChartPanel.GraphPane.GraphObjList.Add(box);
                }
            }

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            ServerBusyChartPanel.GraphPane.YAxis.IsVisible = false;
            ServerBusyChartPanel.AxisChange();
            ServerBusyChartPanel.Invalidate();
            // -- End Plotting 

            LoadCustomerQueueGraph();

            LoadQueueHistogramGraph();
        }

        private void IDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServerBusyChartPanel.GraphPane.CurveList.Clear();
            ServerBusyChartPanel.GraphPane.GraphObjList.Clear();

            // -- Begin Plotting .. 
            List<double> xData = new List<double>();
            List<double> yData = new List<double>();

            DataGridView data = Program.simulationTableForm.outputDataGrid;

            double MaxGraphValue = Convert.ToDouble(Program.simulationTableForm.outputDataGrid.Rows[Program.simulationTableForm.outputDataGrid.Rows.Count - 1].Cells[8].Value);

            GraphPane myPane = ServerBusyChartPanel.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Server Busy Time for Server #" + IDs.Items[IDs.SelectedIndex].ToString();
            myPane.XAxis.Title.Text = "Busy Time In Hours";
            myPane.YAxis.Title.Text = "Occurrence";

            myPane.XAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Min = 0;

            myPane.XAxis.Scale.Max = MaxGraphValue;
            myPane.YAxis.Scale.Max = MaxGraphValue;

            ServerBusyChartPanel.ZoomOut(myPane);

            myPane.Chart.Fill = new Fill(Color.White, Color.FromArgb(255, 255, 166), 90F);
            myPane.Fill = new Fill(Color.FromArgb(250, 250, 255));

            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i].Cells[4].Value.ToString() == IDs.Items[IDs.SelectedIndex].ToString())
                {
                    double begin = Convert.ToDouble(data.Rows[i].Cells[5].Value), end = Convert.ToDouble(data.Rows[i].Cells[8].Value);

                    BoxObj box = new BoxObj(begin, MaxGraphValue / 4, end - begin, MaxGraphValue / 4, Color.Empty, Color.Red);
                    box.IsVisible = true;
                    box.Location.CoordinateFrame = CoordType.AxisXYScale;
                    box.ZOrder = ZOrder.A_InFront;
                    ServerBusyChartPanel.GraphPane.GraphObjList.Add(box);
                }
            }

            ServerBusyChartPanel.AxisChange();
            ServerBusyChartPanel.Invalidate();
            // -- End Plotting 
        }
    }
}