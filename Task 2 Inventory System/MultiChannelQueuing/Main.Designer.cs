namespace InventorySystemTask
{
    partial class mainForm
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
            this.purchasePriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.InterarrivalTimeDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maxPurchasedTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minPurchasedTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.numOfDaysTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.scrapValueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sellingPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearTypesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearDemandButton = new System.Windows.Forms.Button();
            this.demandDataGridView = new System.Windows.Forms.DataGridView();
            this.demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dayTypeDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.startSimulationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // purchasePriceTextBox
            // 
            this.purchasePriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.purchasePriceTextBox.Location = new System.Drawing.Point(149, 23);
            this.purchasePriceTextBox.Name = "purchasePriceTextBox";
            this.purchasePriceTextBox.Size = new System.Drawing.Size(79, 27);
            this.purchasePriceTextBox.TabIndex = 6;
            this.purchasePriceTextBox.Text = "0.33";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Purchase Price ($)";
            // 
            // dayTypeDataGridView
            // 
            this.dayTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dayTypeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dayTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InterarrivalTimeDGV,
            this.ProbabilityDGV});
            this.dayTypeDataGridView.Location = new System.Drawing.Point(15, 123);
            this.dayTypeDataGridView.Name = "dayTypeDataGridView";
            this.dayTypeDataGridView.Size = new System.Drawing.Size(437, 196);
            this.dayTypeDataGridView.TabIndex = 9;
            this.dayTypeDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dayTypeDGV_RowsAdded);
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
            this.label2.Location = new System.Drawing.Point(68, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "System Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maxPurchasedTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.minPurchasedTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.addTypeButton);
            this.groupBox2.Controls.Add(this.numOfDaysTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.scrapValueTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sellingPriceTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.clearTypesButton);
            this.groupBox2.Controls.Add(this.purchasePriceTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dayTypeDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 363);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "System Parameters";
            // 
            // maxPurchasedTextBox
            // 
            this.maxPurchasedTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.maxPurchasedTextBox.Location = new System.Drawing.Point(373, 82);
            this.maxPurchasedTextBox.Name = "maxPurchasedTextBox";
            this.maxPurchasedTextBox.Size = new System.Drawing.Size(79, 27);
            this.maxPurchasedTextBox.TabIndex = 29;
            this.maxPurchasedTextBox.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(234, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Max. Purchased";
            // 
            // minPurchasedTextBox
            // 
            this.minPurchasedTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.minPurchasedTextBox.Location = new System.Drawing.Point(149, 82);
            this.minPurchasedTextBox.Name = "minPurchasedTextBox";
            this.minPurchasedTextBox.Size = new System.Drawing.Size(79, 27);
            this.minPurchasedTextBox.TabIndex = 27;
            this.minPurchasedTextBox.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Min. Purchased";
            // 
            // addTypeButton
            // 
            this.addTypeButton.Location = new System.Drawing.Point(83, 327);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(133, 30);
            this.addTypeButton.TabIndex = 26;
            this.addTypeButton.Text = "Add Type";
            this.addTypeButton.UseVisualStyleBackColor = true;
            this.addTypeButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // numOfDaysTextBox
            // 
            this.numOfDaysTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numOfDaysTextBox.Location = new System.Drawing.Point(373, 53);
            this.numOfDaysTextBox.Name = "numOfDaysTextBox";
            this.numOfDaysTextBox.Size = new System.Drawing.Size(79, 27);
            this.numOfDaysTextBox.TabIndex = 24;
            this.numOfDaysTextBox.Text = "70";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(234, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Number of Days";
            // 
            // scrapValueTextBox
            // 
            this.scrapValueTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.scrapValueTextBox.Location = new System.Drawing.Point(149, 53);
            this.scrapValueTextBox.Name = "scrapValueTextBox";
            this.scrapValueTextBox.Size = new System.Drawing.Size(79, 27);
            this.scrapValueTextBox.TabIndex = 22;
            this.scrapValueTextBox.Text = "0.05";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Scrap Value ($)";
            // 
            // sellingPriceTextBox
            // 
            this.sellingPriceTextBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sellingPriceTextBox.Location = new System.Drawing.Point(373, 23);
            this.sellingPriceTextBox.Name = "sellingPriceTextBox";
            this.sellingPriceTextBox.Size = new System.Drawing.Size(79, 27);
            this.sellingPriceTextBox.TabIndex = 20;
            this.sellingPriceTextBox.Text = "0.50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(234, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Selling Price ($)";
            // 
            // clearTypesButton
            // 
            this.clearTypesButton.Location = new System.Drawing.Point(222, 327);
            this.clearTypesButton.Name = "clearTypesButton";
            this.clearTypesButton.Size = new System.Drawing.Size(133, 30);
            this.clearTypesButton.TabIndex = 19;
            this.clearTypesButton.Text = "Clear Values";
            this.clearTypesButton.UseVisualStyleBackColor = true;
            this.clearTypesButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearDemandButton);
            this.groupBox1.Controls.Add(this.demandDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(535, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 363);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demand Probability Disribution";
            // 
            // clearDemandButton
            // 
            this.clearDemandButton.Location = new System.Drawing.Point(167, 325);
            this.clearDemandButton.Name = "clearDemandButton";
            this.clearDemandButton.Size = new System.Drawing.Size(114, 30);
            this.clearDemandButton.TabIndex = 17;
            this.clearDemandButton.Text = "Clear Values";
            this.clearDemandButton.UseVisualStyleBackColor = true;
            // 
            // demandDataGridView
            // 
            this.demandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.demandDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.demandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.demandDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.demand});
            this.demandDataGridView.Location = new System.Drawing.Point(16, 26);
            this.demandDataGridView.Name = "demandDataGridView";
            this.demandDataGridView.Size = new System.Drawing.Size(416, 293);
            this.demandDataGridView.TabIndex = 10;
            // 
            // demand
            // 
            this.demand.HeaderText = "Demand";
            this.demand.Name = "demand";
            this.demand.Width = 93;
            // 
            // mainForm
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
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayTypeDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.demandDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button startSimulationButton;
        public System.Windows.Forms.TextBox purchasePriceTextBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dayTypeDataGridView;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearTypesButton;
        public System.Windows.Forms.TextBox scrapValueTextBox;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox sellingPriceTextBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox numOfDaysTextBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearDemandButton;
        public System.Windows.Forms.DataGridView demandDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterarrivalTimeDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityDGV;
        private System.Windows.Forms.Button addTypeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn demand;
        public System.Windows.Forms.TextBox maxPurchasedTextBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox minPurchasedTextBox;
        public System.Windows.Forms.Label label4;
    }
}

