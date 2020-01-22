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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_start = new System.Windows.Forms.Button();
            this.chart_ElectrodeData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox_options = new System.Windows.Forms.ListBox();
            this.button_select = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ElectrodeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(21, 12);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // chart_ElectrodeData
            // 
            chartArea17.Name = "ChartArea1";
            this.chart_ElectrodeData.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart_ElectrodeData.Legends.Add(legend17);
            this.chart_ElectrodeData.Location = new System.Drawing.Point(229, 7);
            this.chart_ElectrodeData.Name = "chart_ElectrodeData";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series1";
            this.chart_ElectrodeData.Series.Add(series17);
            this.chart_ElectrodeData.Size = new System.Drawing.Size(559, 104);
            this.chart_ElectrodeData.TabIndex = 1;
            this.chart_ElectrodeData.Text = "chart_ElectrodeData";
            // 
            // listBox_options
            // 
            this.listBox_options.FormattingEnabled = true;
            this.listBox_options.Location = new System.Drawing.Point(20, 41);
            this.listBox_options.Name = "listBox_options";
            this.listBox_options.Size = new System.Drawing.Size(187, 394);
            this.listBox_options.TabIndex = 2;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(133, 12);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 23);
            this.button_select.TabIndex = 3;
            this.button_select.Text = "Select";
            this.button_select.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea18.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart1.Legends.Add(legend18);
            this.chart1.Location = new System.Drawing.Point(229, 117);
            this.chart1.Name = "chart1";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chart1.Series.Add(series18);
            this.chart1.Size = new System.Drawing.Size(559, 104);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea19.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chart2.Legends.Add(legend19);
            this.chart2.Location = new System.Drawing.Point(229, 227);
            this.chart2.Name = "chart2";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Series1";
            this.chart2.Series.Add(series19);
            this.chart2.Size = new System.Drawing.Size(559, 104);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea20.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chart3.Legends.Add(legend20);
            this.chart3.Location = new System.Drawing.Point(229, 337);
            this.chart3.Name = "chart3";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Series1";
            this.chart3.Series.Add(series20);
            this.chart3.Size = new System.Drawing.Size(559, 104);
            this.chart3.TabIndex = 6;
            this.chart3.Text = "chart3";
            // 
            // EEG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.listBox_options);
            this.Controls.Add(this.chart_ElectrodeData);
            this.Controls.Add(this.button_start);
            this.Name = "EEG";
            this.Text = "EEG";
            ((System.ComponentModel.ISupportInitialize)(this.chart_ElectrodeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ElectrodeData;
        private System.Windows.Forms.ListBox listBox_options;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
    }
}

