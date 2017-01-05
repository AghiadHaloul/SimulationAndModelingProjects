namespace orderUpToLevelProblem
{
    partial class SimulationTableForm
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
            this.randomDigitsForDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeServiceBegins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDurationRandomValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeServiceEnds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadTimeDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysUntilOrderArrives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trialNumberLabel = new System.Windows.Forms.Label();
            this.trialsComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.shortageQuantityAvgTextBox = new System.Windows.Forms.TextBox();
            this.shortageQuantityAvgLabel = new System.Windows.Forms.Label();
            this.endingInventoryAvgTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewChartsButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.shortageQuantityAverageAllTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endingInventoryAverageAllTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputDataGrid
            // 
            this.outputDataGrid.AllowUserToAddRows = false;
            this.outputDataGrid.AllowUserToDeleteRows = false;
            this.outputDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.outputDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNo,
            this.InterArrivalRandomValue,
            this.interArrivalTime,
            this.arrivalTime,
            this.randomDigitsForDemand,
            this.serverIndex,
            this.timeServiceBegins,
            this.ServiceDurationRandomValue,
            this.serviceDuration,
            this.timeServiceEnds,
            this.LeadTimeDays,
            this.DaysUntilOrderArrives});
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
            this.customerNo.HeaderText = "Day";
            this.customerNo.Name = "customerNo";
            this.customerNo.ReadOnly = true;
            // 
            // InterArrivalRandomValue
            // 
            this.InterArrivalRandomValue.HeaderText = "Cycle";
            this.InterArrivalRandomValue.Name = "InterArrivalRandomValue";
            this.InterArrivalRandomValue.ReadOnly = true;
            // 
            // interArrivalTime
            // 
            this.interArrivalTime.HeaderText = "Day Within Cycle";
            this.interArrivalTime.Name = "interArrivalTime";
            this.interArrivalTime.ReadOnly = true;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Beginning Inventory";
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.ReadOnly = true;
            // 
            // randomDigitsForDemand
            // 
            this.randomDigitsForDemand.HeaderText = "random Digits For Demand";
            this.randomDigitsForDemand.Name = "randomDigitsForDemand";
            this.randomDigitsForDemand.ReadOnly = true;
            // 
            // serverIndex
            // 
            this.serverIndex.HeaderText = "Demand";
            this.serverIndex.Name = "serverIndex";
            this.serverIndex.ReadOnly = true;
            // 
            // timeServiceBegins
            // 
            this.timeServiceBegins.HeaderText = "Ending Inventory";
            this.timeServiceBegins.Name = "timeServiceBegins";
            this.timeServiceBegins.ReadOnly = true;
            // 
            // ServiceDurationRandomValue
            // 
            this.ServiceDurationRandomValue.HeaderText = "Shortage Quanity";
            this.ServiceDurationRandomValue.Name = "ServiceDurationRandomValue";
            this.ServiceDurationRandomValue.ReadOnly = true;
            // 
            // serviceDuration
            // 
            this.serviceDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.serviceDuration.HeaderText = "Order Quantity";
            this.serviceDuration.Name = "serviceDuration";
            this.serviceDuration.ReadOnly = true;
            this.serviceDuration.Width = 96;
            // 
            // timeServiceEnds
            // 
            this.timeServiceEnds.HeaderText = "Random Digits for Lead Days";
            this.timeServiceEnds.Name = "timeServiceEnds";
            this.timeServiceEnds.ReadOnly = true;
            // 
            // LeadTimeDays
            // 
            this.LeadTimeDays.HeaderText = "Lead Time (days)";
            this.LeadTimeDays.Name = "LeadTimeDays";
            this.LeadTimeDays.ReadOnly = true;
            // 
            // DaysUntilOrderArrives
            // 
            this.DaysUntilOrderArrives.HeaderText = "Days Until Order Arrives";
            this.DaysUntilOrderArrives.Name = "DaysUntilOrderArrives";
            this.DaysUntilOrderArrives.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trialNumberLabel);
            this.groupBox1.Controls.Add(this.trialsComboBox);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.shortageQuantityAvgTextBox);
            this.groupBox1.Controls.Add(this.shortageQuantityAvgLabel);
            this.groupBox1.Controls.Add(this.endingInventoryAvgTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(843, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 183);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "Trial Details";
            // 
            // trialNumberLabel
            // 
            this.trialNumberLabel.AutoSize = true;
            this.trialNumberLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.trialNumberLabel.Location = new System.Drawing.Point(18, 78);
            this.trialNumberLabel.Name = "trialNumberLabel";
            this.trialNumberLabel.Size = new System.Drawing.Size(103, 19);
            this.trialNumberLabel.TabIndex = 29;
            this.trialNumberLabel.Text = "Trial Number";
            // 
            // trialsComboBox
            // 
            this.trialsComboBox.FormattingEnabled = true;
            this.trialsComboBox.Location = new System.Drawing.Point(318, 75);
            this.trialsComboBox.Name = "trialsComboBox";
            this.trialsComboBox.Size = new System.Drawing.Size(100, 27);
            this.trialsComboBox.TabIndex = 28;
            this.trialsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // shortageQuantityAvgTextBox
            // 
            this.shortageQuantityAvgTextBox.Location = new System.Drawing.Point(318, 137);
            this.shortageQuantityAvgTextBox.Name = "shortageQuantityAvgTextBox";
            this.shortageQuantityAvgTextBox.ReadOnly = true;
            this.shortageQuantityAvgTextBox.Size = new System.Drawing.Size(100, 27);
            this.shortageQuantityAvgTextBox.TabIndex = 15;
            // 
            // shortageQuantityAvgLabel
            // 
            this.shortageQuantityAvgLabel.AutoSize = true;
            this.shortageQuantityAvgLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.shortageQuantityAvgLabel.Location = new System.Drawing.Point(18, 143);
            this.shortageQuantityAvgLabel.Name = "shortageQuantityAvgLabel";
            this.shortageQuantityAvgLabel.Size = new System.Drawing.Size(200, 19);
            this.shortageQuantityAvgLabel.TabIndex = 14;
            this.shortageQuantityAvgLabel.Text = "Shortage Quantity Average";
            // 
            // endingInventoryAvgTextBox
            // 
            this.endingInventoryAvgTextBox.Location = new System.Drawing.Point(318, 104);
            this.endingInventoryAvgTextBox.Name = "endingInventoryAvgTextBox";
            this.endingInventoryAvgTextBox.ReadOnly = true;
            this.endingInventoryAvgTextBox.Size = new System.Drawing.Size(100, 27);
            this.endingInventoryAvgTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ending Inventory Average";
            // 
            // ViewChartsButton
            // 
            this.ViewChartsButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewChartsButton.Location = new System.Drawing.Point(843, 595);
            this.ViewChartsButton.Name = "ViewChartsButton";
            this.ViewChartsButton.Size = new System.Drawing.Size(424, 48);
            this.ViewChartsButton.TabIndex = 13;
            this.ViewChartsButton.Text = "View Frequency Distribution Histogram";
            this.ViewChartsButton.UseVisualStyleBackColor = true;
            this.ViewChartsButton.Click += new System.EventHandler(this.ViewChartsBTN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.shortageQuantityAverageAllTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.endingInventoryAverageAllTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox2.Location = new System.Drawing.Point(843, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 183);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 23);
            this.label5.TabIndex = 40;
            this.label5.Text = "Simulation Details";
            // 
            // shortageQuantityAverageAllTextBox
            // 
            this.shortageQuantityAverageAllTextBox.Location = new System.Drawing.Point(309, 115);
            this.shortageQuantityAverageAllTextBox.Name = "shortageQuantityAverageAllTextBox";
            this.shortageQuantityAverageAllTextBox.ReadOnly = true;
            this.shortageQuantityAverageAllTextBox.Size = new System.Drawing.Size(100, 27);
            this.shortageQuantityAverageAllTextBox.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Shortage Quantity Average";
            // 
            // endingInventoryAverageAllTextBox
            // 
            this.endingInventoryAverageAllTextBox.Location = new System.Drawing.Point(309, 82);
            this.endingInventoryAverageAllTextBox.Name = "endingInventoryAverageAllTextBox";
            this.endingInventoryAverageAllTextBox.ReadOnly = true;
            this.endingInventoryAverageAllTextBox.Size = new System.Drawing.Size(100, 27);
            this.endingInventoryAverageAllTextBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ending Inventory Average";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 588);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SimulationTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 647);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ViewChartsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outputDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Table";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SimulationTable_FormClosed);
            this.Load += new System.EventHandler(this.SimulationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView outputDataGrid;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox shortageQuantityAvgTextBox;
        public System.Windows.Forms.Label shortageQuantityAvgLabel;
        public System.Windows.Forms.TextBox endingInventoryAvgTextBox;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ViewChartsButton;
        public System.Windows.Forms.Label trialNumberLabel;
        public System.Windows.Forms.ComboBox trialsComboBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox shortageQuantityAverageAllTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox endingInventoryAverageAllTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrivalRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn interArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDigitsForDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeServiceBegins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDurationRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeServiceEnds;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadTimeDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysUntilOrderArrives;
        
    }
}