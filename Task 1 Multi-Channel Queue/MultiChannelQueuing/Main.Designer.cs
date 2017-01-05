namespace MultiChannelQueuing
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
            this.numberOfCustomersTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.systemDataGridView = new System.Windows.Forms.DataGridView();
            this.InterarrivalTimeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servrersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.clearServerValuesButton = new System.Windows.Forms.Button();
            this.addServerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearInterArrivalTimeButton = new System.Windows.Forms.Button();
            this.selectionMethodComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servrersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulationButton.Location = new System.Drawing.Point(13, 394);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(526, 38);
            this.startSimulationButton.TabIndex = 5;
            this.startSimulationButton.Text = "Start Simulation";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberOfCustomersTextBox
            // 
            this.numberOfCustomersTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numberOfCustomersTextBox.Location = new System.Drawing.Point(177, 26);
            this.numberOfCustomersTextBox.Name = "numberOfCustomersTextBox";
            this.numberOfCustomersTextBox.Size = new System.Drawing.Size(79, 27);
            this.numberOfCustomersTextBox.TabIndex = 6;
            this.numberOfCustomersTextBox.Text = "50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of Customers:";
            // 
            // systemDataGridView
            // 
            this.systemDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.systemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.systemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTimeDGV,
            this.ProbabilityDGV});
            this.systemDataGridView.Location = new System.Drawing.Point(6, 59);
            this.systemDataGridView.Name = "systemDataGridView";
            this.systemDataGridView.Size = new System.Drawing.Size(246, 230);
            this.systemDataGridView.TabIndex = 9;
            // 
            // InterarrivalTimeDGV
            // 
            this.InterarrivalTimeDGV.HeaderText = "Inter-arrival Time";
            this.InterarrivalTimeDGV.Name = "InterarrivalTimeDGV";
            // 
            // ProbabilityDGV
            // 
            this.ProbabilityDGV.HeaderText = "Probability";
            this.ProbabilityDGV.Name = "ProbabilityDGV";
            // 
            // servrersDataGridView
            // 
            this.servrersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servrersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servrersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.servrersDataGridView.Location = new System.Drawing.Point(6, 59);
            this.servrersDataGridView.Name = "servrersDataGridView";
            this.servrersDataGridView.Size = new System.Drawing.Size(246, 230);
            this.servrersDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Service Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Probability";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.clearServerValuesButton);
            this.groupBox1.Controls.Add(this.addServerButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.servrersDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(287, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 337);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servers\' Parameters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "0";
            // 
            // clearServerValuesButton
            // 
            this.clearServerValuesButton.Location = new System.Drawing.Point(138, 295);
            this.clearServerValuesButton.Name = "clearServerValuesButton";
            this.clearServerValuesButton.Size = new System.Drawing.Size(114, 30);
            this.clearServerValuesButton.TabIndex = 17;
            this.clearServerValuesButton.Text = "Clear Values";
            this.clearServerValuesButton.UseVisualStyleBackColor = true;
            this.clearServerValuesButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(6, 295);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(114, 30);
            this.addServerButton.TabIndex = 16;
            this.addServerButton.Text = "Add Server";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter Data for Server ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.groupBox2.Controls.Add(this.clearInterArrivalTimeButton);
            this.groupBox2.Controls.Add(this.numberOfCustomersTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.systemDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 337);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Parameters";
            // 
            // clearInterArrivalTimeButton
            // 
            this.clearInterArrivalTimeButton.Location = new System.Drawing.Point(66, 295);
            this.clearInterArrivalTimeButton.Name = "clearInterArrivalTimeButton";
            this.clearInterArrivalTimeButton.Size = new System.Drawing.Size(133, 30);
            this.clearInterArrivalTimeButton.TabIndex = 19;
            this.clearInterArrivalTimeButton.Text = "Clear Values";
            this.clearInterArrivalTimeButton.UseVisualStyleBackColor = true;
            this.clearInterArrivalTimeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // selectionMethodComboBox
            // 
            this.selectionMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionMethodComboBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.selectionMethodComboBox.FormattingEnabled = true;
            this.selectionMethodComboBox.Items.AddRange(new object[] {
            "Highest Priority",
            "Random",
            "Lowest Utilization"});
            this.selectionMethodComboBox.Location = new System.Drawing.Point(293, 361);
            this.selectionMethodComboBox.Name = "selectionMethodComboBox";
            this.selectionMethodComboBox.Size = new System.Drawing.Size(153, 27);
            this.selectionMethodComboBox.TabIndex = 15;
            this.selectionMethodComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(102, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Server Selection Method";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectionMethodComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startSimulationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Channel Queue";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servrersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button startSimulationButton;
        public System.Windows.Forms.TextBox numberOfCustomersTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView systemDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTimeDGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityDGV;
        public System.Windows.Forms.DataGridView servrersDataGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addServerButton;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox selectionMethodComboBox;
        private System.Windows.Forms.Button clearServerValuesButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clearInterArrivalTimeButton;
    }
}

