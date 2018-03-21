namespace MonitoringClient
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uxAutoRefreshField = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "⠂Monitoring panel ⠂";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "GetCities";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "GetStations";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "GetAvailableBikes";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "GetInformations";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(608, 285);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Number of client requests over time";
            this.chart1.Titles.Add(title1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1092, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load charts";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(3, 294);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "StationInfo";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "StationsList";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "StationsOfCity";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "CitiesList";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(608, 283);
            this.chart2.TabIndex = 9;
            this.chart2.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Number of request to Velib WS";
            this.chart2.Titles.Add(title2);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(617, 3);
            this.chart3.Name = "chart3";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "GetCities";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "GetStations";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "GetAvailableBikes";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "GetInformations";
            this.chart3.Series.Add(series9);
            this.chart3.Series.Add(series10);
            this.chart3.Series.Add(series11);
            this.chart3.Series.Add(series12);
            this.chart3.Size = new System.Drawing.Size(623, 285);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            title3.Name = "Title1";
            title3.Text = "Average execution time (ms)";
            this.chart3.Titles.Add(title3);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(617, 294);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series13.ChartArea = "ChartArea1";
            series13.Legend = "Legend1";
            series13.Name = "Connected clients";
            this.chart4.Series.Add(series13);
            this.chart4.Size = new System.Drawing.Size(623, 283);
            this.chart4.TabIndex = 11;
            this.chart4.Text = "chart4";
            title4.Name = "Title1";
            title4.Text = "Number of connected clients";
            this.chart4.Titles.Add(title4);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.chart3);
            this.flowLayoutPanel1.Controls.Add(this.chart2);
            this.flowLayoutPanel1.Controls.Add(this.chart4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1245, 589);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // uxAutoRefreshField
            // 
            this.uxAutoRefreshField.AutoSize = true;
            this.uxAutoRefreshField.Location = new System.Drawing.Point(963, 37);
            this.uxAutoRefreshField.Name = "uxAutoRefreshField";
            this.uxAutoRefreshField.Size = new System.Drawing.Size(83, 17);
            this.uxAutoRefreshField.TabIndex = 13;
            this.uxAutoRefreshField.Text = "Auto refresh";
            this.uxAutoRefreshField.UseVisualStyleBackColor = true;
            this.uxAutoRefreshField.CheckedChanged += new System.EventHandler(this.uxAutoRefreshField_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 666);
            this.Controls.Add(this.uxAutoRefreshField);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Monitoring";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox uxAutoRefreshField;
    }
}

