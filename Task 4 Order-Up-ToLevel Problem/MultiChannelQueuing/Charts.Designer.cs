namespace orderUpToLevelProblem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bar = new System.Windows.Forms.RadioButton();
            this.pie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Location = new System.Drawing.Point(12, 56);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Name = "ColumnChart";
            series3.YValuesPerPoint = 2;
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(950, 456);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // bar
            // 
            this.bar.AutoSize = true;
            this.bar.Checked = true;
            this.bar.Font = new System.Drawing.Font("Tahoma", 12F);
            this.bar.Location = new System.Drawing.Point(369, 518);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(93, 23);
            this.bar.TabIndex = 16;
            this.bar.TabStop = true;
            this.bar.Text = "Bar Chart";
            this.bar.UseVisualStyleBackColor = true;
            // 
            // pie
            // 
            this.pie.AutoSize = true;
            this.pie.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pie.Location = new System.Drawing.Point(502, 518);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(91, 23);
            this.pie.TabIndex = 17;
            this.pie.Text = "Pie Chart";
            this.pie.UseVisualStyleBackColor = true;
            this.pie.CheckedChanged += new System.EventHandler(this.pie_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(23, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number of Ranges";
            this.label1.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(170, 551);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 20;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label2.Location = new System.Drawing.Point(237, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Frequency Distribution of Average Ending Inventory";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Charts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequency Distribution Chart";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton bar;
        private System.Windows.Forms.RadioButton pie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}