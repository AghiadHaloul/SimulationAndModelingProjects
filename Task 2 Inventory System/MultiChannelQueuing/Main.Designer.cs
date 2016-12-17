namespace InventorySystemTask
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayTypeDGV = new System.Windows.Forms.DataGridView();
            this.InterarrivalTimeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxPurchased = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minPurchased = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.numOfDays = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DemandDGV = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dayTypeDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DemandDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(470, 752);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1052, 73);
            this.button1.TabIndex = 5;
            this.button1.Text = "Start Simulation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(298, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 46);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0.33";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Purchase Price ($)";
            // 
            // dayTypeDGV
            // 
            this.dayTypeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dayTypeDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dayTypeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayTypeDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTimeDGV,
            this.ProbabilityDGV});
            this.dayTypeDGV.Location = new System.Drawing.Point(30, 237);
            this.dayTypeDGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dayTypeDGV.Name = "dayTypeDGV";
            this.dayTypeDGV.Size = new System.Drawing.Size(874, 377);
            this.dayTypeDGV.TabIndex = 9;
            this.dayTypeDGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dayTypeDGV_RowsAdded);
            // 
            // InterarrivalTimeDGV
            // 
            this.InterarrivalTimeDGV.HeaderText = "Type of Newsday";
            this.InterarrivalTimeDGV.Name = "InterarrivalTimeDGV";
            // 
            // ProbabilityDGV
            // 
            this.ProbabilityDGV.HeaderText = "Probability";
            this.ProbabilityDGV.Name = "ProbabilityDGV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(136, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "System Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxPurchased);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.minPurchased);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.numOfDays);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dayTypeDGV);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(26, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(932, 698);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Parameters";
            // 
            // maxPurchased
            // 
            this.maxPurchased.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maxPurchased.Location = new System.Drawing.Point(746, 158);
            this.maxPurchased.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maxPurchased.Name = "maxPurchased";
            this.maxPurchased.Size = new System.Drawing.Size(154, 46);
            this.maxPurchased.TabIndex = 29;
            this.maxPurchased.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(468, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 39);
            this.label3.TabIndex = 30;
            this.label3.Text = "Max. Purchased";
            // 
            // minPurchased
            // 
            this.minPurchased.Font = new System.Drawing.Font("Tahoma", 12F);
            this.minPurchased.Location = new System.Drawing.Point(298, 158);
            this.minPurchased.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.minPurchased.Name = "minPurchased";
            this.minPurchased.Size = new System.Drawing.Size(154, 46);
            this.minPurchased.TabIndex = 27;
            this.minPurchased.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(12, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 39);
            this.label4.TabIndex = 28;
            this.label4.Text = "Min. Purchased";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(166, 629);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(266, 58);
            this.button4.TabIndex = 26;
            this.button4.Text = "Add Type";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // numOfDays
            // 
            this.numOfDays.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numOfDays.Location = new System.Drawing.Point(746, 102);
            this.numOfDays.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.numOfDays.Name = "numOfDays";
            this.numOfDays.Size = new System.Drawing.Size(154, 46);
            this.numOfDays.TabIndex = 24;
            this.numOfDays.Text = "70";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(468, 108);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 39);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number of Days";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox3.Location = new System.Drawing.Point(298, 102);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 46);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "0.05";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(12, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 39);
            this.label6.TabIndex = 23;
            this.label6.Text = "Scrap Value ($)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox2.Location = new System.Drawing.Point(746, 44);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 46);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "0.50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(468, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "Selling Price ($)";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(444, 629);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(266, 58);
            this.button3.TabIndex = 19;
            this.button3.Text = "Clear Values";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.DemandDGV);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1070, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(892, 698);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demand Probability Disribution";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 625);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 58);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear Values";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DemandDGV
            // 
            this.DemandDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DemandDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DemandDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DemandDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand});
            this.DemandDGV.Location = new System.Drawing.Point(32, 50);
            this.DemandDGV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DemandDGV.Name = "DemandDGV";
            this.DemandDGV.Size = new System.Drawing.Size(832, 563);
            this.DemandDGV.TabIndex = 10;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            this.demand.Width = 181;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1986, 848);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayTypeDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DemandDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dayTypeDGV;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox numOfDays;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView DemandDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTimeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        public System.Windows.Forms.TextBox maxPurchased;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox minPurchased;
        public System.Windows.Forms.Label label4;
    }
}

