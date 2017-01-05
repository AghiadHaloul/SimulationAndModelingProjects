namespace MultiChannelQueuing
{
    partial class Charts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ServerBusyTimes = new System.Windows.Forms.TabPage();
            this.ServerBusyChartPanel = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.IDs = new System.Windows.Forms.ComboBox();
            this.QueueSizeHistogram = new System.Windows.Forms.TabPage();
            this.QueueSizeHistogramPanel = new ZedGraph.ZedGraphControl();
            this.CustomersQueueGraph = new System.Windows.Forms.TabPage();
            this.CustomerQueueGraphPanel = new ZedGraph.ZedGraphControl();
            this.Tabs.SuspendLayout();
            this.ServerBusyTimes.SuspendLayout();
            this.QueueSizeHistogram.SuspendLayout();
            this.CustomersQueueGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ServerBusyTimes);
            this.Tabs.Controls.Add(this.QueueSizeHistogram);
            this.Tabs.Controls.Add(this.CustomersQueueGraph);
            this.Tabs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabs.Location = new System.Drawing.Point(12, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1025, 549);
            this.Tabs.TabIndex = 14;
            // 
            // ServerBusyTimes
            // 
            this.ServerBusyTimes.Controls.Add(this.ServerBusyChartPanel);
            this.ServerBusyTimes.Controls.Add(this.label1);
            this.ServerBusyTimes.Controls.Add(this.IDs);
            this.ServerBusyTimes.Location = new System.Drawing.Point(4, 28);
            this.ServerBusyTimes.Name = "ServerBusyTimes";
            this.ServerBusyTimes.Padding = new System.Windows.Forms.Padding(3);
            this.ServerBusyTimes.Size = new System.Drawing.Size(1017, 517);
            this.ServerBusyTimes.TabIndex = 0;
            this.ServerBusyTimes.Text = "Server Busy Time";
            this.ServerBusyTimes.UseVisualStyleBackColor = true;
            // 
            // ServerBusyChartPanel
            // 
            this.ServerBusyChartPanel.Location = new System.Drawing.Point(20, 51);
            this.ServerBusyChartPanel.Name = "ServerBusyChartPanel";
            this.ServerBusyChartPanel.ScrollGrace = 0D;
            this.ServerBusyChartPanel.ScrollMaxX = 0D;
            this.ServerBusyChartPanel.ScrollMaxY = 0D;
            this.ServerBusyChartPanel.ScrollMaxY2 = 0D;
            this.ServerBusyChartPanel.ScrollMinX = 0D;
            this.ServerBusyChartPanel.ScrollMinY = 0D;
            this.ServerBusyChartPanel.ScrollMinY2 = 0D;
            this.ServerBusyChartPanel.Size = new System.Drawing.Size(978, 446);
            this.ServerBusyChartPanel.TabIndex = 13;
            //this.ServerBusyChartPanel.UseExtendedPrintDialog = true;
            this.ServerBusyChartPanel.ZoomStepFraction = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select the server ID which you want to see its busy time:";
            // 
            // IDs
            // 
            this.IDs.FormattingEnabled = true;
            this.IDs.Location = new System.Drawing.Point(439, 18);
            this.IDs.Name = "IDs";
            this.IDs.Size = new System.Drawing.Size(89, 27);
            this.IDs.TabIndex = 11;
            this.IDs.Text = "0";
            this.IDs.SelectedIndexChanged += new System.EventHandler(this.IDs_SelectedIndexChanged);
            // 
            // QueueSizeHistogram
            // 
            this.QueueSizeHistogram.Controls.Add(this.QueueSizeHistogramPanel);
            this.QueueSizeHistogram.Location = new System.Drawing.Point(4, 28);
            this.QueueSizeHistogram.Name = "QueueSizeHistogram";
            this.QueueSizeHistogram.Padding = new System.Windows.Forms.Padding(3);
            this.QueueSizeHistogram.Size = new System.Drawing.Size(1017, 517);
            this.QueueSizeHistogram.TabIndex = 1;
            this.QueueSizeHistogram.Text = "Queue Size Histogram";
            this.QueueSizeHistogram.UseVisualStyleBackColor = true;
            // 
            // QueueSizeHistogramPanel
            // 
            this.QueueSizeHistogramPanel.Location = new System.Drawing.Point(7, 6);
            this.QueueSizeHistogramPanel.Name = "QueueSizeHistogramPanel";
            this.QueueSizeHistogramPanel.ScrollGrace = 0D;
            this.QueueSizeHistogramPanel.ScrollMaxX = 0D;
            this.QueueSizeHistogramPanel.ScrollMaxY = 0D;
            this.QueueSizeHistogramPanel.ScrollMaxY2 = 0D;
            this.QueueSizeHistogramPanel.ScrollMinX = 0D;
            this.QueueSizeHistogramPanel.ScrollMinY = 0D;
            this.QueueSizeHistogramPanel.ScrollMinY2 = 0D;
            this.QueueSizeHistogramPanel.Size = new System.Drawing.Size(1005, 505);
            this.QueueSizeHistogramPanel.TabIndex = 0;
            //this.QueueSizeHistogramPanel.UseExtendedPrintDialog = true;
            this.QueueSizeHistogramPanel.ZoomStepFraction = 0D;
            // 
            // CustomersQueueGraph
            // 
            this.CustomersQueueGraph.Controls.Add(this.CustomerQueueGraphPanel);
            this.CustomersQueueGraph.Location = new System.Drawing.Point(4, 28);
            this.CustomersQueueGraph.Name = "CustomersQueueGraph";
            this.CustomersQueueGraph.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersQueueGraph.Size = new System.Drawing.Size(1017, 517);
            this.CustomersQueueGraph.TabIndex = 2;
            this.CustomersQueueGraph.Text = "Customers Queue Graph";
            this.CustomersQueueGraph.UseVisualStyleBackColor = true;
            // 
            // CustomerQueueGraphPanel
            // 
            this.CustomerQueueGraphPanel.Location = new System.Drawing.Point(6, 6);
            this.CustomerQueueGraphPanel.Name = "CustomerQueueGraphPanel";
            this.CustomerQueueGraphPanel.ScrollGrace = 0D;
            this.CustomerQueueGraphPanel.ScrollMaxX = 0D;
            this.CustomerQueueGraphPanel.ScrollMaxY = 0D;
            this.CustomerQueueGraphPanel.ScrollMaxY2 = 0D;
            this.CustomerQueueGraphPanel.ScrollMinX = 0D;
            this.CustomerQueueGraphPanel.ScrollMinY = 0D;
            this.CustomerQueueGraphPanel.ScrollMinY2 = 0D;
            this.CustomerQueueGraphPanel.Size = new System.Drawing.Size(1005, 505);
            this.CustomerQueueGraphPanel.TabIndex = 0;
            //this.CustomerQueueGraphPanel.UseExtendedPrintDialog = true;
            this.CustomerQueueGraphPanel.ZoomStepFraction = 0D;
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 564);
            this.Controls.Add(this.Tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Charts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            this.Tabs.ResumeLayout(false);
            this.ServerBusyTimes.ResumeLayout(false);
            this.ServerBusyTimes.PerformLayout();
            this.QueueSizeHistogram.ResumeLayout(false);
            this.CustomersQueueGraph.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ServerBusyTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDs;
        private System.Windows.Forms.TabPage QueueSizeHistogram;
        private System.Windows.Forms.TabPage CustomersQueueGraph;
        private ZedGraph.ZedGraphControl ServerBusyChartPanel;
        private ZedGraph.ZedGraphControl CustomerQueueGraphPanel;
        private ZedGraph.ZedGraphControl QueueSizeHistogramPanel;
    }
}