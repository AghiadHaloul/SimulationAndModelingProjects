namespace orderUpToLevelProblem
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barRadioButton = new System.Windows.Forms.RadioButton();
            this.pieRadioButton = new System.Windows.Forms.RadioButton();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.Location = new System.Drawing.Point(12, 56);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "ColumnChart";
            series1.YValuesPerPoint = 2;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(950, 456);
            this.chart.TabIndex = 15;
            this.chart.Text = "chart1";
            // 
            // barRadioButton
            // 
            this.barRadioButton.AutoSize = true;
            this.barRadioButton.Checked = true;
            this.barRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.barRadioButton.Location = new System.Drawing.Point(369, 518);
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
            this.pieRadioButton.Location = new System.Drawing.Point(502, 518);
            this.pieRadioButton.Name = "pieRadioButton";
            this.pieRadioButton.Size = new System.Drawing.Size(91, 23);
            this.pieRadioButton.TabIndex = 17;
            this.pieRadioButton.Text = "Pie Chart";
            this.pieRadioButton.UseVisualStyleBackColor = true;
            this.pieRadioButton.CheckedChanged += new System.EventHandler(this.pie_CheckedChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.titleLabel.Location = new System.Drawing.Point(237, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(469, 24);
            this.titleLabel.TabIndex = 21;
            this.titleLabel.Text = "Frequency Distribution of Average Ending Inventory";
            // 
            // ChartsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 554);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pieRadioButton);
            this.Controls.Add(this.barRadioButton);
            this.Controls.Add(this.chart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequency Distribution Chart";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.RadioButton barRadioButton;
        private System.Windows.Forms.RadioButton pieRadioButton;
        private System.Windows.Forms.Label titleLabel;
    }
}