namespace InventorySystemTask
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
            this.statsGroupBox = new System.Windows.Forms.GroupBox();
            this.optimalNumberTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.purchasedPapersComboBox = new System.Windows.Forms.ComboBox();
            this.unsoldPapersTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.excessDemandTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NetProfitTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salvageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lostProfitTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.costOfNewspaperTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.revnueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewChartsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGrid)).BeginInit();
            this.statsGroupBox.SuspendLayout();
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
            this.serverIndex,
            this.timeServiceBegins,
            this.ServiceDurationRandomValue,
            this.serviceDuration,
            this.timeServiceEnds});
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
            this.InterArrivalRandomValue.HeaderText = "Day Type Random Value";
            this.InterArrivalRandomValue.Name = "InterArrivalRandomValue";
            this.InterArrivalRandomValue.ReadOnly = true;
            // 
            // interArrivalTime
            // 
            this.interArrivalTime.HeaderText = "Day Type";
            this.interArrivalTime.Name = "interArrivalTime";
            this.interArrivalTime.ReadOnly = true;
            // 
            // arrivalTime
            // 
            this.arrivalTime.HeaderText = "Demand Random Number";
            this.arrivalTime.Name = "arrivalTime";
            this.arrivalTime.ReadOnly = true;
            // 
            // serverIndex
            // 
            this.serverIndex.HeaderText = "Demand";
            this.serverIndex.Name = "serverIndex";
            this.serverIndex.ReadOnly = true;
            // 
            // timeServiceBegins
            // 
            this.timeServiceBegins.HeaderText = "Revenue from Sales";
            this.timeServiceBegins.Name = "timeServiceBegins";
            this.timeServiceBegins.ReadOnly = true;
            // 
            // ServiceDurationRandomValue
            // 
            this.ServiceDurationRandomValue.HeaderText = "Lost Profit from Excess Demand";
            this.ServiceDurationRandomValue.Name = "ServiceDurationRandomValue";
            this.ServiceDurationRandomValue.ReadOnly = true;
            // 
            // serviceDuration
            // 
            this.serviceDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.serviceDuration.HeaderText = "Slavage from sale of Scrap";
            this.serviceDuration.Name = "serviceDuration";
            this.serviceDuration.ReadOnly = true;
            this.serviceDuration.Width = 110;
            // 
            // timeServiceEnds
            // 
            this.timeServiceEnds.HeaderText = "Daily Profit";
            this.timeServiceEnds.Name = "timeServiceEnds";
            this.timeServiceEnds.ReadOnly = true;
            // 
            // statsGroupBox
            // 
            this.statsGroupBox.Controls.Add(this.optimalNumberTextBox);
            this.statsGroupBox.Controls.Add(this.label10);
            this.statsGroupBox.Controls.Add(this.label9);
            this.statsGroupBox.Controls.Add(this.purchasedPapersComboBox);
            this.statsGroupBox.Controls.Add(this.unsoldPapersTextBox);
            this.statsGroupBox.Controls.Add(this.label8);
            this.statsGroupBox.Controls.Add(this.excessDemandTextBox);
            this.statsGroupBox.Controls.Add(this.label7);
            this.statsGroupBox.Controls.Add(this.NetProfitTextBox);
            this.statsGroupBox.Controls.Add(this.label3);
            this.statsGroupBox.Controls.Add(this.salvageTextBox);
            this.statsGroupBox.Controls.Add(this.label2);
            this.statsGroupBox.Controls.Add(this.label1);
            this.statsGroupBox.Controls.Add(this.button2);
            this.statsGroupBox.Controls.Add(this.lostProfitTextBox);
            this.statsGroupBox.Controls.Add(this.label6);
            this.statsGroupBox.Controls.Add(this.costOfNewspaperTextBox);
            this.statsGroupBox.Controls.Add(this.label5);
            this.statsGroupBox.Controls.Add(this.revnueTextBox);
            this.statsGroupBox.Controls.Add(this.label4);
            this.statsGroupBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.statsGroupBox.Location = new System.Drawing.Point(843, 2);
            this.statsGroupBox.Name = "statsGroupBox";
            this.statsGroupBox.Size = new System.Drawing.Size(424, 587);
            this.statsGroupBox.TabIndex = 9;
            this.statsGroupBox.TabStop = false;
            // 
            // optimalNumberTextBox
            // 
            this.optimalNumberTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimalNumberTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.optimalNumberTextBox.Location = new System.Drawing.Point(287, 364);
            this.optimalNumberTextBox.Name = "optimalNumberTextBox";
            this.optimalNumberTextBox.ReadOnly = true;
            this.optimalNumberTextBox.Size = new System.Drawing.Size(119, 27);
            this.optimalNumberTextBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Optimal Number of Newspapers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.Location = new System.Drawing.Point(14, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "Purchased Newspapers:";
            // 
            // purchasedPapersComboBox
            // 
            this.purchasedPapersComboBox.FormattingEnabled = true;
            this.purchasedPapersComboBox.Location = new System.Drawing.Point(285, 31);
            this.purchasedPapersComboBox.Name = "purchasedPapersComboBox";
            this.purchasedPapersComboBox.Size = new System.Drawing.Size(121, 27);
            this.purchasedPapersComboBox.TabIndex = 28;
            this.purchasedPapersComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // unsoldPapersTextBox
            // 
            this.unsoldPapersTextBox.Location = new System.Drawing.Point(307, 327);
            this.unsoldPapersTextBox.Name = "unsoldPapersTextBox";
            this.unsoldPapersTextBox.ReadOnly = true;
            this.unsoldPapersTextBox.Size = new System.Drawing.Size(100, 27);
            this.unsoldPapersTextBox.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(15, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Number of days having unsold papers:";
            // 
            // excessDemandTextBox
            // 
            this.excessDemandTextBox.Location = new System.Drawing.Point(307, 294);
            this.excessDemandTextBox.Name = "excessDemandTextBox";
            this.excessDemandTextBox.ReadOnly = true;
            this.excessDemandTextBox.Size = new System.Drawing.Size(100, 27);
            this.excessDemandTextBox.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(14, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Number of days having excess demand:";
            // 
            // NetProfitTextBox
            // 
            this.NetProfitTextBox.Location = new System.Drawing.Point(308, 263);
            this.NetProfitTextBox.Name = "NetProfitTextBox";
            this.NetProfitTextBox.ReadOnly = true;
            this.NetProfitTextBox.Size = new System.Drawing.Size(100, 27);
            this.NetProfitTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(14, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Net Profit:";
            // 
            // salvageTextBox
            // 
            this.salvageTextBox.Location = new System.Drawing.Point(308, 230);
            this.salvageTextBox.Name = "salvageTextBox";
            this.salvageTextBox.ReadOnly = true;
            this.salvageTextBox.Size = new System.Drawing.Size(100, 27);
            this.salvageTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(15, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total Salvage from sale of Scrap Papers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Performance Measures";
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
            // lostProfitTextBox
            // 
            this.lostProfitTextBox.Location = new System.Drawing.Point(307, 199);
            this.lostProfitTextBox.Name = "lostProfitTextBox";
            this.lostProfitTextBox.ReadOnly = true;
            this.lostProfitTextBox.Size = new System.Drawing.Size(100, 27);
            this.lostProfitTextBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(14, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Lost Profit from Excess Demand:";
            // 
            // costOfNewspaperTextBox
            // 
            this.costOfNewspaperTextBox.Location = new System.Drawing.Point(307, 164);
            this.costOfNewspaperTextBox.Name = "costOfNewspaperTextBox";
            this.costOfNewspaperTextBox.ReadOnly = true;
            this.costOfNewspaperTextBox.Size = new System.Drawing.Size(100, 27);
            this.costOfNewspaperTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(14, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Cost of Newspapers:";
            // 
            // revnueTextBox
            // 
            this.revnueTextBox.Location = new System.Drawing.Point(307, 131);
            this.revnueTextBox.Name = "revnueTextBox";
            this.revnueTextBox.ReadOnly = true;
            this.revnueTextBox.Size = new System.Drawing.Size(100, 27);
            this.revnueTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Revenue from Sales:";
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
            this.Controls.Add(this.statsGroupBox);
            this.Controls.Add(this.outputDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SimulationTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation Table";
            this.Load += new System.EventHandler(this.SimulationTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.outputDataGrid)).EndInit();
            this.statsGroupBox.ResumeLayout(false);
            this.statsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView outputDataGrid;
        public System.Windows.Forms.GroupBox statsGroupBox;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox lostProfitTextBox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox costOfNewspaperTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox revnueTextBox;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ViewChartsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterArrivalRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn interArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeServiceBegins;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDurationRandomValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeServiceEnds;
        public System.Windows.Forms.TextBox unsoldPapersTextBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox excessDemandTextBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox NetProfitTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox salvageTextBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox purchasedPapersComboBox;
        public System.Windows.Forms.TextBox optimalNumberTextBox;
        public System.Windows.Forms.Label label10;
        
    }
}