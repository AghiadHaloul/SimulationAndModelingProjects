namespace orderUpToLevelProblem
{
    partial class Main
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
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.orderUpToLevelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearLeadButton = new System.Windows.Forms.Button();
            this.leadTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.InterarrivalTimeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numOfTrialsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reviewPeriodTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.demandDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearDemandButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadTimeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulationButton.Location = new System.Drawing.Point(235, 391);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(526, 38);
            this.startSimulationButton.TabIndex = 5;
            this.startSimulationButton.Text = "Start Simulation";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
            // 
            // orderUpToLevelTextBox
            // 
            this.orderUpToLevelTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.orderUpToLevelTextBox.Location = new System.Drawing.Point(149, 23);
            this.orderUpToLevelTextBox.Name = "orderUpToLevelTextBox";
            this.orderUpToLevelTextBox.Size = new System.Drawing.Size(79, 27);
            this.orderUpToLevelTextBox.TabIndex = 6;
            this.orderUpToLevelTextBox.Text = "11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order-Up-To Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "System Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearLeadButton);
            this.groupBox2.Controls.Add(this.leadTimeDataGridView);
            this.groupBox2.Controls.Add(this.numOfDaysTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numOfTrialsTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.reviewPeriodTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.orderUpToLevelTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 310);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Parameters";
            // 
            // clearLeadButton
            // 
            this.clearLeadButton.Location = new System.Drawing.Point(169, 264);
            this.clearLeadButton.Name = "clearLeadButton";
            this.clearLeadButton.Size = new System.Drawing.Size(114, 30);
            this.clearLeadButton.TabIndex = 32;
            this.clearLeadButton.Text = "Clear Values";
            this.clearLeadButton.UseVisualStyleBackColor = true;
            // 
            // leadTimeDataGridView
            // 
            this.leadTimeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.leadTimeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leadTimeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTimeDGV,
            this.ProbabilityDGV});
            this.leadTimeDataGridView.Location = new System.Drawing.Point(10, 88);
            this.leadTimeDataGridView.Name = "leadTimeDataGridView";
            this.leadTimeDataGridView.Size = new System.Drawing.Size(451, 170);
            this.leadTimeDataGridView.TabIndex = 18;
            // 
            // InterarrivalTimeDGV
            // 
            this.InterarrivalTimeDGV.HeaderText = "Lead Time";
            this.InterarrivalTimeDGV.Name = "InterarrivalTimeDGV";
            // 
            // ProbabilityDGV
            // 
            this.ProbabilityDGV.HeaderText = "Probability";
            this.ProbabilityDGV.Name = "ProbabilityDGV";
            // 
            // numOfDaysTextBox
            // 
            this.numOfDaysTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numOfDaysTextBox.Location = new System.Drawing.Point(382, 53);
            this.numOfDaysTextBox.Name = "numOfDaysTextBox";
            this.numOfDaysTextBox.Size = new System.Drawing.Size(79, 27);
            this.numOfDaysTextBox.TabIndex = 24;
            this.numOfDaysTextBox.Text = "25";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(243, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number of Days";
            // 
            // numOfTrialsTextBox
            // 
            this.numOfTrialsTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numOfTrialsTextBox.Location = new System.Drawing.Point(149, 53);
            this.numOfTrialsTextBox.Name = "numOfTrialsTextBox";
            this.numOfTrialsTextBox.Size = new System.Drawing.Size(79, 27);
            this.numOfTrialsTextBox.TabIndex = 22;
            this.numOfTrialsTextBox.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number of Trials";
            // 
            // reviewPeriodTextBox
            // 
            this.reviewPeriodTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.reviewPeriodTextBox.Location = new System.Drawing.Point(382, 23);
            this.reviewPeriodTextBox.Name = "reviewPeriodTextBox";
            this.reviewPeriodTextBox.Size = new System.Drawing.Size(79, 27);
            this.reviewPeriodTextBox.TabIndex = 20;
            this.reviewPeriodTextBox.Text = "5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(243, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Review Period";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.demandDataGridView);
            this.groupBox1.Controls.Add(this.clearDemandButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(519, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 310);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demand Probability Disribution";
            // 
            // demandDataGridView
            // 
            this.demandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.demandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.demandDataGridView.Location = new System.Drawing.Point(15, 29);
            this.demandDataGridView.Name = "demandDataGridView";
            this.demandDataGridView.Size = new System.Drawing.Size(415, 229);
            this.demandDataGridView.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Demand";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // clearDemandButton
            // 
            this.clearDemandButton.Location = new System.Drawing.Point(160, 264);
            this.clearDemandButton.Name = "clearDemandButton";
            this.clearDemandButton.Size = new System.Drawing.Size(114, 30);
            this.clearDemandButton.TabIndex = 17;
            this.clearDemandButton.Text = "Clear Values";
            this.clearDemandButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(958, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startSimulationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refrigerator Inventory System";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leadTimeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.demandDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button startSimulationButton;
        public System.Windows.Forms.TextBox orderUpToLevelTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox numOfTrialsTextBox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox reviewPeriodTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox numOfDaysTextBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearDemandButton;
        public System.Windows.Forms.DataGridView leadTimeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTimeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityDGV;
        public System.Windows.Forms.DataGridView demandDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button clearLeadButton;
    }
}

