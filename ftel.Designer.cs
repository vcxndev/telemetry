namespace ftel
{
    partial class ftel
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sport = new System.IO.Ports.SerialPort(this.components);
            this.COMlist = new System.Windows.Forms.ComboBox();
            this.baudList = new System.Windows.Forms.ComboBox();
            this.connector = new System.Windows.Forms.Button();
            this.chartVT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cVolt = new System.Windows.Forms.Label();
            this.cTemp = new System.Windows.Forms.Label();
            this.cSpeed = new System.Windows.Forms.Label();
            this.avSpeed = new System.Windows.Forms.Label();
            this.range = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartS)).BeginInit();
            this.SuspendLayout();
            // 
            // COMlist
            // 
            this.COMlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMlist.FormattingEnabled = true;
            this.COMlist.Location = new System.Drawing.Point(859, 694);
            this.COMlist.Name = "COMlist";
            this.COMlist.Size = new System.Drawing.Size(121, 21);
            this.COMlist.TabIndex = 0;
            // 
            // baudList
            // 
            this.baudList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudList.FormattingEnabled = true;
            this.baudList.Items.AddRange(new object[] {
            110,
            300,
            600,
            1200,
            2400,
            4800,
            9600,
            14400,
            19200,
            38400,
            57600,
            115200,
            128000,
            256000});
            this.baudList.Location = new System.Drawing.Point(986, 694);
            this.baudList.Name = "baudList";
            this.baudList.Size = new System.Drawing.Size(121, 21);
            this.baudList.TabIndex = 1;
            // 
            // connector
            // 
            this.connector.Location = new System.Drawing.Point(1113, 694);
            this.connector.Name = "connector";
            this.connector.Size = new System.Drawing.Size(121, 21);
            this.connector.TabIndex = 2;
            this.connector.Text = "Connect";
            this.connector.UseVisualStyleBackColor = true;
            this.connector.Click += new System.EventHandler(this.connector_Click);
            // 
            // chartVT
            // 
            this.chartVT.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
            chartArea1.Name = "ChartArea1";
            chartArea1.AxisX.Interval = 1;
            this.chartVT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartVT.Legends.Add(legend1);
            this.chartVT.Location = new System.Drawing.Point(49, 35);
            this.chartVT.Name = "chartVT";
            this.chartVT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chartVT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "volts";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "temps";
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartVT.Series.Add(series1);
            this.chartVT.Series.Add(series2);
            this.chartVT.Size = new System.Drawing.Size(819, 291);
            this.chartVT.TabIndex = 3;
            this.chartVT.Text = "Temp-Voltage";
            // 
            // chartS
            // 
            chartArea2.Name = "ChartArea1";
            this.chartS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartS.Legends.Add(legend2);
            this.chartS.Location = new System.Drawing.Point(49, 348);
            this.chartS.Name = "chartS";
            this.chartS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "speed";
            this.chartS.Series.Add(series3);
            this.chartS.Size = new System.Drawing.Size(819, 300);
            this.chartS.TabIndex = 4;
            this.chartS.Text = "chartS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(905, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Voltage        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(904, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(905, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Range                       :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(901, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average Speed         :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(905, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current Speed          :";
            // 
            // cVolt
            // 
            this.cVolt.AutoSize = true;
            this.cVolt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cVolt.Location = new System.Drawing.Point(1157, 127);
            this.cVolt.Name = "cVolt";
            this.cVolt.Size = new System.Drawing.Size(59, 31);
            this.cVolt.TabIndex = 10;
            this.cVolt.Text = "999";
            // 
            // cTemp
            // 
            this.cTemp.AutoSize = true;
            this.cTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cTemp.Location = new System.Drawing.Point(1157, 187);
            this.cTemp.Name = "cTemp";
            this.cTemp.Size = new System.Drawing.Size(59, 31);
            this.cTemp.TabIndex = 11;
            this.cTemp.Text = "999";
            // 
            // cSpeed
            // 
            this.cSpeed.AutoSize = true;
            this.cSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cSpeed.Location = new System.Drawing.Point(1157, 397);
            this.cSpeed.Name = "cSpeed";
            this.cSpeed.Size = new System.Drawing.Size(59, 31);
            this.cSpeed.TabIndex = 12;
            this.cSpeed.Text = "999";
            // 
            // avSpeed
            // 
            this.avSpeed.AutoSize = true;
            this.avSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.avSpeed.Location = new System.Drawing.Point(1157, 467);
            this.avSpeed.Name = "avSpeed";
            this.avSpeed.Size = new System.Drawing.Size(59, 31);
            this.avSpeed.TabIndex = 13;
            this.avSpeed.Text = "999";
            // 
            // range
            // 
            this.range.AutoSize = true;
            this.range.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.range.Location = new System.Drawing.Point(1157, 541);
            this.range.Name = "range";
            this.range.Size = new System.Drawing.Size(59, 31);
            this.range.TabIndex = 14;
            this.range.Text = "999";
            // 
            // ftel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 738);
            this.Controls.Add(this.range);
            this.Controls.Add(this.avSpeed);
            this.Controls.Add(this.cSpeed);
            this.Controls.Add(this.cTemp);
            this.Controls.Add(this.cVolt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartS);
            this.Controls.Add(this.chartVT);
            this.Controls.Add(this.connector);
            this.Controls.Add(this.baudList);
            this.Controls.Add(this.COMlist);
            this.Name = "ftel";
            this.Text = "telemetry";
            ((System.ComponentModel.ISupportInitialize)(this.chartVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.IO.Ports.SerialPort sport;
        private System.Windows.Forms.ComboBox COMlist;
        private System.Windows.Forms.ComboBox baudList;
        private System.Windows.Forms.Button connector;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cVolt;
        private System.Windows.Forms.Label cTemp;
        private System.Windows.Forms.Label cSpeed;
        private System.Windows.Forms.Label avSpeed;
        private System.Windows.Forms.Label range;
        private System.Threading.Thread bReciever;
    }
}

