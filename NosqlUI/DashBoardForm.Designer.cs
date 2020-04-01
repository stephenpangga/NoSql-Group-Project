namespace NosqlUI
{
    partial class DashBoardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.UnresolvedPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnresolvedPie)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(226, 46);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(410, 46);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(594, 46);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(54, 141);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(166, 124);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(550, 18);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(77, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Welcome User";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(52, 56);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(71, 13);
            this.lbl_amount.TabIndex = 5;
            this.lbl_amount.Text = "ticket amount";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(465, 141);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(190, 124);
            this.chart2.TabIndex = 6;
            this.chart2.Text = "chart2";
            // 
            // UnresolvedPie
            // 
            chartArea3.Name = "ChartArea1";
            this.UnresolvedPie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.UnresolvedPie.Legends.Add(legend3);
            this.UnresolvedPie.Location = new System.Drawing.Point(260, 141);
            this.UnresolvedPie.Name = "UnresolvedPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.UnresolvedPie.Series.Add(series3);
            this.UnresolvedPie.Size = new System.Drawing.Size(178, 124);
            this.UnresolvedPie.TabIndex = 7;
            this.UnresolvedPie.Text = "Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "InProcess";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "UnResolved";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(675, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Resolved";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Software";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hardware";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Incident Type";
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 558);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnresolvedPie);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.chart1);
            this.Name = "DashBoardForm";
            this.Text = "Dashboard";
            this.Controls.SetChildIndex(this.chart1, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.lbl_amount, 0);
            this.Controls.SetChildIndex(this.chart2, 0);
            this.Controls.SetChildIndex(this.UnresolvedPie, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnresolvedPie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart UnresolvedPie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
    }
}