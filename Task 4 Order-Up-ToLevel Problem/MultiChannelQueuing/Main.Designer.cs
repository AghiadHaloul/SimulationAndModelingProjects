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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numOfTrialsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.reviewPeriodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numOfDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.orderUpToLevelNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clearLeadButton = new System.Windows.Forms.Button();
            this.leadTimeDataGridView = new System.Windows.Forms.DataGridView();
            this.InterarrivalTimeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.demandDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearDemandButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.aValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfTrialsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewPeriodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDaysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderUpToLevelNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadTimeDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.demandDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cValueNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aValueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulationButton.Location = new System.Drawing.Point(245, 408);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(526, 38);
            this.startSimulationButton.TabIndex = 5;
            this.startSimulationButton.Text = "Start Simulation";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startSimulationButton_Click);
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
            this.groupBox2.Controls.Add(this.numOfTrialsNumericUpDown);
            this.groupBox2.Controls.Add(this.reviewPeriodNumericUpDown);
            this.groupBox2.Controls.Add(this.numOfDaysNumericUpDown);
            this.groupBox2.Controls.Add(this.orderUpToLevelNumericUpDown);
            this.groupBox2.Controls.Add(this.clearLeadButton);
            this.groupBox2.Controls.Add(this.leadTimeDataGridView);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 310);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Parameters";
            // 
            // numOfTrialsNumericUpDown
            // 
            this.numOfTrialsNumericUpDown.Location = new System.Drawing.Point(154, 54);
            this.numOfTrialsNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOfTrialsNumericUpDown.Name = "numOfTrialsNumericUpDown";
            this.numOfTrialsNumericUpDown.Size = new System.Drawing.Size(83, 27);
            this.numOfTrialsNumericUpDown.TabIndex = 36;
            this.numOfTrialsNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // reviewPeriodNumericUpDown
            // 
            this.reviewPeriodNumericUpDown.Location = new System.Drawing.Point(375, 23);
            this.reviewPeriodNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.reviewPeriodNumericUpDown.Name = "reviewPeriodNumericUpDown";
            this.reviewPeriodNumericUpDown.Size = new System.Drawing.Size(86, 27);
            this.reviewPeriodNumericUpDown.TabIndex = 35;
            this.reviewPeriodNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numOfDaysNumericUpDown
            // 
            this.numOfDaysNumericUpDown.Location = new System.Drawing.Point(375, 53);
            this.numOfDaysNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numOfDaysNumericUpDown.Name = "numOfDaysNumericUpDown";
            this.numOfDaysNumericUpDown.Size = new System.Drawing.Size(86, 27);
            this.numOfDaysNumericUpDown.TabIndex = 34;
            this.numOfDaysNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // orderUpToLevelNumericUpDown
            // 
            this.orderUpToLevelNumericUpDown.Location = new System.Drawing.Point(154, 21);
            this.orderUpToLevelNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.orderUpToLevelNumericUpDown.Name = "orderUpToLevelNumericUpDown";
            this.orderUpToLevelNumericUpDown.Size = new System.Drawing.Size(83, 27);
            this.orderUpToLevelNumericUpDown.TabIndex = 33;
            this.orderUpToLevelNumericUpDown.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // clearLeadButton
            // 
            this.clearLeadButton.Location = new System.Drawing.Point(169, 264);
            this.clearLeadButton.Name = "clearLeadButton";
            this.clearLeadButton.Size = new System.Drawing.Size(114, 30);
            this.clearLeadButton.TabIndex = 32;
            this.clearLeadButton.Text = "Clear Values";
            this.clearLeadButton.UseVisualStyleBackColor = true;
            this.clearLeadButton.Click += new System.EventHandler(this.clearLeadButton_Click);
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
            this.clearDemandButton.Click += new System.EventHandler(this.clearDemandButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(365, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(230, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(75, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "A";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mValueNumericUpDown);
            this.groupBox3.Controls.Add(this.cValueNumericUpDown);
            this.groupBox3.Controls.Add(this.aValueNumericUpDown);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(237, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 73);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LCG Parameters";
            // 
            // mValueNumericUpDown
            // 
            this.mValueNumericUpDown.CausesValidation = false;
            this.mValueNumericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.mValueNumericUpDown.Location = new System.Drawing.Point(392, 26);
            this.mValueNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mValueNumericUpDown.Name = "mValueNumericUpDown";
            this.mValueNumericUpDown.ReadOnly = true;
            this.mValueNumericUpDown.Size = new System.Drawing.Size(83, 27);
            this.mValueNumericUpDown.TabIndex = 37;
            this.mValueNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // cValueNumericUpDown
            // 
            this.cValueNumericUpDown.Location = new System.Drawing.Point(255, 26);
            this.cValueNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cValueNumericUpDown.Name = "cValueNumericUpDown";
            this.cValueNumericUpDown.Size = new System.Drawing.Size(83, 27);
            this.cValueNumericUpDown.TabIndex = 38;
            this.cValueNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // aValueNumericUpDown
            // 
            this.aValueNumericUpDown.Location = new System.Drawing.Point(101, 26);
            this.aValueNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.aValueNumericUpDown.Name = "aValueNumericUpDown";
            this.aValueNumericUpDown.Size = new System.Drawing.Size(83, 27);
            this.aValueNumericUpDown.TabIndex = 39;
            this.aValueNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(958, 454);
            this.Controls.Add(this.groupBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.numOfTrialsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reviewPeriodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfDaysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderUpToLevelNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadTimeDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.demandDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cValueNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aValueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button startSimulationButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
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
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.NumericUpDown numOfTrialsNumericUpDown;
        public System.Windows.Forms.NumericUpDown reviewPeriodNumericUpDown;
        public System.Windows.Forms.NumericUpDown numOfDaysNumericUpDown;
        public System.Windows.Forms.NumericUpDown orderUpToLevelNumericUpDown;
        public System.Windows.Forms.NumericUpDown mValueNumericUpDown;
        public System.Windows.Forms.NumericUpDown cValueNumericUpDown;
        public System.Windows.Forms.NumericUpDown aValueNumericUpDown;
    }
}

