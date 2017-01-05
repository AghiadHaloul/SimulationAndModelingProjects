namespace InventorySystemTask
{
    partial class ChartsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barRadioButton = new System.Windows.Forms.RadioButton();
            this.pieRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rangesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Location = new System.Drawing.Point(12, 56);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "ColumnChart";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(950, 456);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // barRadioButton
            // 
            this.barRadioButton.AutoSize = true;
            this.barRadioButton.Checked = true;
            this.barRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.barRadioButton.Location = new System.Drawing.Point(513, 526);
            this.barRadioButton.Name = "barRadioButton";
            this.barRadioButton.Size = new System.Drawing.Size(93, 23);
            this.barRadioButton.TabIndex = 16;
            this.barRadioButton.TabStop = true;
            this.barRadioButton.Text = "Bar Chart";
            this.barRadioButton.UseVisualStyleBackColor = true;
            // 
            // pieRadioButton
            // 
            this.pieRadioButton.AutoSize = true;
            this.pieRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pieRadioButton.Location = new System.Drawing.Point(513, 555);
            this.pieRadioButton.Name = "pieRadioButton";
            this.pieRadioButton.Size = new System.Drawing.Size(91, 23);
            this.pieRadioButton.TabIndex = 17;
            this.pieRadioButton.Text = "Pie Chart";
            this.pieRadioButton.UseVisualStyleBackColor = true;
            this.pieRadioButton.CheckedChanged += new System.EventHandler(this.pie_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(208, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number of Ranges";
            // 
            // rangesNumericUpDown
            // 
            this.rangesNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.rangesNumericUpDown.Location = new System.Drawing.Point(355, 540);
            this.rangesNumericUpDown.Name = "rangesNumericUpDown";
            this.rangesNumericUpDown.ReadOnly = true;
            this.rangesNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.rangesNumericUpDown.TabIndex = 20;
            this.rangesNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rangesNumericUpDown.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.titleLabel.Location = new System.Drawing.Point(365, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(228, 24);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Frequency of Daily Profit";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 594);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.rangesNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieRadioButton);
            this.Controls.Add(this.barRadioButton);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton barRadioButton;
        private System.Windows.Forms.RadioButton pieRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rangesNumericUpDown;
        private System.Windows.Forms.Label titleLabel;
    }
}