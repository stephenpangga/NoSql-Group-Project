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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.overAllChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_name = new System.Windows.Forms.Label();
            this.inProcessChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.unResolvedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.resolvedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_unresolved = new System.Windows.Forms.Label();
            this.lbl_inprocess = new System.Windows.Forms.Label();
            this.lbl_resolved = new System.Windows.Forms.Label();
            this.lbl_urgent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.overAllChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProcessChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unResolvedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolvedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(276, 56);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(460, 56);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(644, 56);
            // 
            // linegrBox
            // 
            this.linegrBox.Location = new System.Drawing.Point(12, 93);
            this.linegrBox.Size = new System.Drawing.Size(900, 10);
            // 
            // overAllChart
            // 
            this.overAllChart.BorderlineColor = System.Drawing.Color.Black;
            this.overAllChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.overAllChart.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.overAllChart.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.overAllChart.BorderSkin.BorderWidth = 8;
            chartArea1.Name = "ChartArea1";
            this.overAllChart.ChartAreas.Add(chartArea1);
            this.overAllChart.Location = new System.Drawing.Point(46, 109);
            this.overAllChart.Name = "overAllChart";
            this.overAllChart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.overAllChart.Series.Add(series1);
            this.overAllChart.Size = new System.Drawing.Size(208, 201);
            this.overAllChart.TabIndex = 3;
            this.overAllChart.Text = "chart1";
            this.overAllChart.Click += new System.EventHandler(this.overAllChart_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(640, 22);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(113, 20);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Welcome User";
            // 
            // inProcessChart
            // 
            this.inProcessChart.BorderlineColor = System.Drawing.Color.Black;
            this.inProcessChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.inProcessChart.ChartAreas.Add(chartArea2);
            this.inProcessChart.Location = new System.Drawing.Point(479, 109);
            this.inProcessChart.Name = "inProcessChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.inProcessChart.Series.Add(series2);
            this.inProcessChart.Size = new System.Drawing.Size(208, 201);
            this.inProcessChart.TabIndex = 6;
            this.inProcessChart.Text = "chart2";
            this.inProcessChart.Click += new System.EventHandler(this.inProcessChart_Click);
            // 
            // unResolvedChart
            // 
            this.unResolvedChart.BorderlineColor = System.Drawing.Color.Black;
            this.unResolvedChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.unResolvedChart.ChartAreas.Add(chartArea3);
            this.unResolvedChart.Location = new System.Drawing.Point(260, 109);
            this.unResolvedChart.Name = "unResolvedChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.unResolvedChart.Series.Add(series3);
            this.unResolvedChart.Size = new System.Drawing.Size(208, 201);
            this.unResolvedChart.TabIndex = 7;
            this.unResolvedChart.Text = "Chart";
            this.unResolvedChart.Click += new System.EventHandler(this.unResolvedChart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Software";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hardware";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Incident Type";
            // 
            // resolvedChart
            // 
            this.resolvedChart.BorderlineColor = System.Drawing.Color.Black;
            this.resolvedChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.resolvedChart.ChartAreas.Add(chartArea4);
            this.resolvedChart.Location = new System.Drawing.Point(693, 109);
            this.resolvedChart.Name = "resolvedChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.Name = "Series1";
            this.resolvedChart.Series.Add(series4);
            this.resolvedChart.Size = new System.Drawing.Size(208, 201);
            this.resolvedChart.TabIndex = 16;
            this.resolvedChart.Text = "chart2";
            this.resolvedChart.Click += new System.EventHandler(this.resolvedChart_Click);
            // 
            // lbl_unresolved
            // 
            this.lbl_unresolved.AutoSize = true;
            this.lbl_unresolved.BackColor = System.Drawing.Color.White;
            this.lbl_unresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unresolved.Location = new System.Drawing.Point(338, 206);
            this.lbl_unresolved.Name = "lbl_unresolved";
            this.lbl_unresolved.Size = new System.Drawing.Size(55, 24);
            this.lbl_unresolved.TabIndex = 18;
            this.lbl_unresolved.Text = "1/100";
            this.lbl_unresolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inprocess
            // 
            this.lbl_inprocess.AutoSize = true;
            this.lbl_inprocess.BackColor = System.Drawing.Color.White;
            this.lbl_inprocess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inprocess.Location = new System.Drawing.Point(556, 206);
            this.lbl_inprocess.Name = "lbl_inprocess";
            this.lbl_inprocess.Size = new System.Drawing.Size(55, 24);
            this.lbl_inprocess.TabIndex = 19;
            this.lbl_inprocess.Text = "1/100";
            // 
            // lbl_resolved
            // 
            this.lbl_resolved.AutoSize = true;
            this.lbl_resolved.BackColor = System.Drawing.Color.White;
            this.lbl_resolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resolved.Location = new System.Drawing.Point(767, 206);
            this.lbl_resolved.Name = "lbl_resolved";
            this.lbl_resolved.Size = new System.Drawing.Size(55, 24);
            this.lbl_resolved.TabIndex = 20;
            this.lbl_resolved.Text = "1/100";
            // 
            // lbl_urgent
            // 
            this.lbl_urgent.AutoSize = true;
            this.lbl_urgent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_urgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_urgent.Location = new System.Drawing.Point(276, 360);
            this.lbl_urgent.Name = "lbl_urgent";
            this.lbl_urgent.Size = new System.Drawing.Size(140, 27);
            this.lbl_urgent.TabIndex = 0;
            this.lbl_urgent.Text = "Urgent Tickets";
            this.lbl_urgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_urgent.Click += new System.EventHandler(this.lbl_urgent_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 666);
            this.Controls.Add(this.lbl_urgent);
            this.Controls.Add(this.lbl_resolved);
            this.Controls.Add(this.lbl_inprocess);
            this.Controls.Add(this.lbl_unresolved);
            this.Controls.Add(this.resolvedChart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.unResolvedChart);
            this.Controls.Add(this.inProcessChart);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.overAllChart);
            this.Name = "DashBoardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.Controls.SetChildIndex(this.linegrBox, 0);
            this.Controls.SetChildIndex(this.overAllChart, 0);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.inProcessChart, 0);
            this.Controls.SetChildIndex(this.unResolvedChart, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.resolvedChart, 0);
            this.Controls.SetChildIndex(this.lbl_unresolved, 0);
            this.Controls.SetChildIndex(this.lbl_inprocess, 0);
            this.Controls.SetChildIndex(this.lbl_resolved, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            this.Controls.SetChildIndex(this.lbl_urgent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.overAllChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProcessChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unResolvedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolvedChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart overAllChart;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataVisualization.Charting.Chart inProcessChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart unResolvedChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart resolvedChart;
        private System.Windows.Forms.Label lbl_unresolved;
        private System.Windows.Forms.Label lbl_inprocess;
        private System.Windows.Forms.Label lbl_resolved;
        private System.Windows.Forms.Label lbl_urgent;
    }
}