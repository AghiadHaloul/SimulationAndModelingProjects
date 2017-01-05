namespace MultiChannelQueuing
{
    partial class SimulationTable
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
            this.outputDataGrid = new System.Windows.Forms.DataGridView();
            this.customerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterArrivalRandomValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeServiceBegins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDurationRandomValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeServiceEnds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDelay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.utilizationGroupBox = new System.Windows.Forms.GroupBox();
            this.utilizationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.probOfQueueTextBox = new System.Windows.Forms.TextBox();
            this.probOfWaitLabel = new System.Windows.Forms.Label();
            this.maxQueueLengthTextBox = new System.Windows.Forms.TextBox();
            this.maxQueueLabel = new System.Windows.Forms.Label();
            this.avgQueueWaitTextBox = new System.Windows.Forms.TextBox();
            this.avgQueueLabel = new System.Windows.Forms.Label();
            this.avgServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.avgServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.ServerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewChartsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGrid)).BeginInit();
            this.InfoGroupBox.SuspendLayout();
            this.utilizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utilizationDataGridView)).BeginInit();
            this.avgServiceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avgServiceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // outputDataGrid
            // 
            this.outputDataGrid.AllowUserToAddRows = false;
            this.outputDataGrid.AllowUserToDeleteRows = false;
            this.outputDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNo,
            this.InterArrivalRandomValue,
            this.interArrivalTime,
            this.arrivalTime,
            this.serverIndex,
            this.timeServiceBegins,
            this.ServiceDurationRandomValue,
            this.serviceDuration,
            this.timeServiceEnds,
            this.totalDelay});
            this.outputDataGrid.Location = new System.Drawing.Point(12, 12);
            this.outputDataGrid.Name = "outputDataGrid";
            this.outputDataGrid.ReadOnly = true;
            this.outputDataGrid.RowHeadersVisible = false;
            this.outputDataGrid.RowTemplate.ReadOnly = true;
            this.outputDataGrid.Size = new System.Drawing.Size(825, 631);
            this.outputDataGrid.TabIndex = 1;
            // 
            // customerNo
            // 
            this.customerNo.HeaderText = "Customer Number";
            this.customerNo.Name = "customerNo";
            this.customerNo.ReadOnly = true;
            // 
            // InterArrivalRandomValue
            // 
            this.InterArrivalRandomValue.HeaderText = "Inter-Arrival Random Value";
            this.InterArrivalRandomValue.Name = "InterArrivalRandomValue";
            this.InterArrivalRandomValue.ReadOnly = true;
            // 
            // interArrivalTime
            // 
            this.interArrivalTime.HeaderText = "Inter-Arrival Time";
            this.interArrivalTime.Name = "interArrivalTime";
            this.interArrivalTime.ReadOnly = true;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Arrival Time";
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.ReadOnly = true;
            // 
            // serverIndex
            // 
            this.serverIndex.HeaderText = "Server Index";
            this.serverIndex.Name = "serverIndex";
            this.serverIndex.ReadOnly = true;
            // 
            // timeServiceBegins
            // 
            this.timeServiceBegins.HeaderText = "Time Service Begins";
            this.timeServiceBegins.Name = "timeServiceBegins";
            this.timeServiceBegins.ReadOnly = true;
            // 
            // ServiceDurationRandomValue
            // 
            this.ServiceDurationRandomValue.HeaderText = "Service Duration Random Value";
            this.ServiceDurationRandomValue.Name = "ServiceDurationRandomValue";
            this.ServiceDurationRandomValue.ReadOnly = true;
            // 
            // serviceDuration
            // 
            this.serviceDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.serviceDuration.HeaderText = "Service Duration";
            this.serviceDuration.Name = "serviceDuration";
            this.serviceDuration.ReadOnly = true;
            this.serviceDuration.Width = 102;
            // 
            // timeServiceEnds
            // 
            this.timeServiceEnds.HeaderText = "Time Service Ends";
            this.timeServiceEnds.Name = "timeServiceEnds";
            this.timeServiceEnds.ReadOnly = true;
            // 
            // totalDelay
            // 
            this.totalDelay.HeaderText = "Total Delay";
            this.totalDelay.Name = "totalDelay";
            this.totalDelay.ReadOnly = true;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.utilizationGroupBox);
            this.InfoGroupBox.Controls.Add(this.resultsLabel);
            this.InfoGroupBox.Controls.Add(this.button2);
            this.InfoGroupBox.Controls.Add(this.probOfQueueTextBox);
            this.InfoGroupBox.Controls.Add(this.probOfWaitLabel);
            this.InfoGroupBox.Controls.Add(this.maxQueueLengthTextBox);
            this.InfoGroupBox.Controls.Add(this.maxQueueLabel);
            this.InfoGroupBox.Controls.Add(this.avgQueueWaitTextBox);
            this.InfoGroupBox.Controls.Add(this.avgQueueLabel);
            this.InfoGroupBox.Controls.Add(this.avgServiceGroupBox);
            this.InfoGroupBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.InfoGroupBox.Location = new System.Drawing.Point(843, 2);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(424, 587);
            this.InfoGroupBox.TabIndex = 9;
            this.InfoGroupBox.TabStop = false;
            // 
            // utilizationGroupBox
            // 
            this.utilizationGroupBox.Controls.Add(this.utilizationDataGridView);
            this.utilizationGroupBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.utilizationGroupBox.Location = new System.Drawing.Point(75, 279);
            this.utilizationGroupBox.Name = "utilizationGroupBox";
            this.utilizationGroupBox.Size = new System.Drawing.Size(278, 188);
            this.utilizationGroupBox.TabIndex = 1;
            this.utilizationGroupBox.TabStop = false;
            this.utilizationGroupBox.Text = "Utilization Time";
            // 
            // utilizationDataGridView
            // 
            this.utilizationDataGridView.AllowUserToAddRows = false;
            this.utilizationDataGridView.AllowUserToDeleteRows = false;
            this.utilizationDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.utilizationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.utilizationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.utilizationDataGridView.Location = new System.Drawing.Point(7, 20);
            this.utilizationDataGridView.Name = "utilizationDataGridView";
            this.utilizationDataGridView.RowHeadersVisible = false;
            this.utilizationDataGridView.Size = new System.Drawing.Size(258, 152);
            this.utilizationDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "ServerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Idle %";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(9, 26);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(344, 19);
            this.resultsLabel.TabIndex = 19;
            this.resultsLabel.Text = "Results after simulating the system with ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 18;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // probOfQueueTextBox
            // 
            this.probOfQueueTextBox.Location = new System.Drawing.Point(282, 552);
            this.probOfQueueTextBox.Name = "probOfQueueTextBox";
            this.probOfQueueTextBox.ReadOnly = true;
            this.probOfQueueTextBox.Size = new System.Drawing.Size(100, 27);
            this.probOfQueueTextBox.TabIndex = 17;
            // 
            // probOfWaitLabel
            // 
            this.probOfWaitLabel.AutoSize = true;
            this.probOfWaitLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.probOfWaitLabel.Location = new System.Drawing.Point(46, 552);
            this.probOfWaitLabel.Name = "probOfWaitLabel";
            this.probOfWaitLabel.Size = new System.Drawing.Size(236, 19);
            this.probOfWaitLabel.TabIndex = 16;
            this.probOfWaitLabel.Text = "Probability of Waiting in Queue:";
            // 
            // maxQueueLengthTextBox
            // 
            this.maxQueueLengthTextBox.Location = new System.Drawing.Point(282, 517);
            this.maxQueueLengthTextBox.Name = "maxQueueLengthTextBox";
            this.maxQueueLengthTextBox.ReadOnly = true;
            this.maxQueueLengthTextBox.Size = new System.Drawing.Size(100, 27);
            this.maxQueueLengthTextBox.TabIndex = 15;
            // 
            // maxQueueLabel
            // 
            this.maxQueueLabel.AutoSize = true;
            this.maxQueueLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maxQueueLabel.Location = new System.Drawing.Point(46, 520);
            this.maxQueueLabel.Name = "maxQueueLabel";
            this.maxQueueLabel.Size = new System.Drawing.Size(188, 19);
            this.maxQueueLabel.TabIndex = 14;
            this.maxQueueLabel.Text = "Maximum Queue Length:";
            // 
            // avgQueueWaitTextBox
            // 
            this.avgQueueWaitTextBox.Location = new System.Drawing.Point(282, 484);
            this.avgQueueWaitTextBox.Name = "avgQueueWaitTextBox";
            this.avgQueueWaitTextBox.ReadOnly = true;
            this.avgQueueWaitTextBox.Size = new System.Drawing.Size(100, 27);
            this.avgQueueWaitTextBox.TabIndex = 13;
            // 
            // avgQueueLabel
            // 
            this.avgQueueLabel.AutoSize = true;
            this.avgQueueLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.avgQueueLabel.Location = new System.Drawing.Point(46, 487);
            this.avgQueueLabel.Name = "avgQueueLabel";
            this.avgQueueLabel.Size = new System.Drawing.Size(223, 19);
            this.avgQueueLabel.TabIndex = 11;
            this.avgQueueLabel.Text = "Average Queue Waiting Time:";
            // 
            // avgServiceGroupBox
            // 
            this.avgServiceGroupBox.Controls.Add(this.avgServiceDataGridView);
            this.avgServiceGroupBox.Font = new System.Drawing.Font("Tahoma", 8F);
            this.avgServiceGroupBox.Location = new System.Drawing.Point(75, 78);
            this.avgServiceGroupBox.Name = "avgServiceGroupBox";
            this.avgServiceGroupBox.Size = new System.Drawing.Size(278, 188);
            this.avgServiceGroupBox.TabIndex = 0;
            this.avgServiceGroupBox.TabStop = false;
            this.avgServiceGroupBox.Text = "Average Service Time";
            // 
            // avgServiceDataGridView
            // 
            this.avgServiceDataGridView.AllowUserToAddRows = false;
            this.avgServiceDataGridView.AllowUserToDeleteRows = false;
            this.avgServiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.avgServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avgServiceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerID,
            this.Average});
            this.avgServiceDataGridView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.avgServiceDataGridView.Location = new System.Drawing.Point(7, 20);
            this.avgServiceDataGridView.Name = "avgServiceDataGridView";
            this.avgServiceDataGridView.RowHeadersVisible = false;
            this.avgServiceDataGridView.Size = new System.Drawing.Size(258, 152);
            this.avgServiceDataGridView.TabIndex = 0;
            // 
            // ServerID
            // 
            this.ServerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerID.HeaderText = "ServerID";
            this.ServerID.Name = "ServerID";
            // 
            // Average
            // 
            this.Average.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Average.HeaderText = "Average Service Time";
            this.Average.Name = "Average";
            this.Average.ReadOnly = true;
            // 
            // ViewChartsButton
            // 
            this.ViewChartsButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewChartsButton.Location = new System.Drawing.Point(843, 595);
            this.ViewChartsButton.Name = "ViewChartsButton";
            this.ViewChartsButton.Size = new System.Drawing.Size(424, 48);
            this.ViewChartsButton.TabIndex = 13;
            this.ViewChartsButton.Text = "View Charts";
            this.ViewChartsButton.UseVisualStyleBackColor = true;
            this.ViewChartsButton.Click += new System.EventHandler(this.ViewChartsBTN_Click);
            // 
            // SimulationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.ViewChartsButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.outputDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Table";
            this.Load += new System.EventHandler(this.SimulationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGrid)).EndInit();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.utilizationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utilizationDataGridView)).EndInit();
            this.avgServiceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avgServiceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView outputDataGrid;
        public System.Windows.Forms.GroupBox InfoGroupBox;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox probOfQueueTextBox;
        public System.Windows.Forms.Label probOfWaitLabel;
        public System.Windows.Forms.TextBox maxQueueLengthTextBox;
        public System.Windows.Forms.Label maxQueueLabel;
        public System.Windows.Forms.TextBox avgQueueWaitTextBox;
        public System.Windows.Forms.Label avgQueueLabel;
        public System.Windows.Forms.GroupBox avgServiceGroupBox;
        private System.Windows.Forms.Button ViewChartsButton;
        private System.Windows.Forms.Label resultsLabel;
        public System.Windows.Forms.GroupBox utilizationGroupBox;
        public System.Windows.Forms.DataGridView utilizationDataGridView;
        public System.Windows.Forms.DataGridView avgServiceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Average;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrivalRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn interArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeServiceBegins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDurationRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeServiceEnds;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDelay;
        
    }
}