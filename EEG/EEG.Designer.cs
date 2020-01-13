namespace EEG
{
    partial class EEG
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_start = new System.Windows.Forms.Button();
            this.chart_ElectrodeData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ElectrodeData)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // chart_ElectrodeData
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ElectrodeData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_ElectrodeData.Legends.Add(legend1);
            this.chart_ElectrodeData.Location = new System.Drawing.Point(205, 12);
            this.chart_ElectrodeData.Name = "chart_ElectrodeData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_ElectrodeData.Series.Add(series1);
            this.chart_ElectrodeData.Size = new System.Drawing.Size(583, 426);
            this.chart_ElectrodeData.TabIndex = 1;
            this.chart_ElectrodeData.Text = "chart_ElectrodeData";
            // 
            // EEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart_ElectrodeData);
            this.Controls.Add(this.button_start);
            this.Name = "EEG";
            this.Text = "EEG";
            ((System.ComponentModel.ISupportInitialize)(this.chart_ElectrodeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ElectrodeData;
    }
}

