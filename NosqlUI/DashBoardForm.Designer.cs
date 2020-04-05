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
            this.resolvedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_unresolved = new System.Windows.Forms.Label();
            this.lbl_inprocess = new System.Windows.Forms.Label();
            this.lbl_resolved = new System.Windows.Forms.Label();
            this.lbl_urgent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_passdeadline = new System.Windows.Forms.Label();
            this.lbl_low = new System.Windows.Forms.Label();
            this.lbl_normal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.overAllChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProcessChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unResolvedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolvedChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(163, 56);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(347, 56);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(531, 56);
            this.btn_UserM.Click += new System.EventHandler(this.btn_UserM_Click);
            // 
            // linegrBox
            // 
            this.linegrBox.Location = new System.Drawing.Point(12, 93);
            this.linegrBox.Size = new System.Drawing.Size(900, 10);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(833, 56);
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
            this.overAllChart.Size = new System.Drawing.Size(267, 246);
            this.overAllChart.TabIndex = 3;
            this.overAllChart.Text = "chart1";
            this.overAllChart.Click += new System.EventHandler(this.overAllChart_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(596, 22);
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
            this.inProcessChart.Location = new System.Drawing.Point(46, 370);
            this.inProcessChart.Name = "inProcessChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series1";
            this.inProcessChart.Series.Add(series2);
            this.inProcessChart.Size = new System.Drawing.Size(267, 246);
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
            this.unResolvedChart.Location = new System.Drawing.Point(351, 109);
            this.unResolvedChart.Name = "unResolvedChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsVisibleInLegend = false;
            series3.Name = "Series1";
            this.unResolvedChart.Series.Add(series3);
            this.unResolvedChart.Size = new System.Drawing.Size(267, 246);
            this.unResolvedChart.TabIndex = 7;
            this.unResolvedChart.Text = "Chart";
            this.unResolvedChart.Click += new System.EventHandler(this.unResolvedChart_Click);
            // 
            // resolvedChart
            // 
            this.resolvedChart.BorderlineColor = System.Drawing.Color.Black;
            this.resolvedChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.Name = "ChartArea1";
            this.resolvedChart.ChartAreas.Add(chartArea4);
            this.resolvedChart.Location = new System.Drawing.Point(351, 370);
            this.resolvedChart.Name = "resolvedChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.Name = "Series1";
            this.resolvedChart.Series.Add(series4);
            this.resolvedChart.Size = new System.Drawing.Size(267, 246);
            this.resolvedChart.TabIndex = 16;
            this.resolvedChart.Text = "chart2";
            this.resolvedChart.Click += new System.EventHandler(this.resolvedChart_Click);
            // 
            // lbl_unresolved
            // 
            this.lbl_unresolved.AutoSize = true;
            this.lbl_unresolved.BackColor = System.Drawing.Color.White;
            this.lbl_unresolved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unresolved.Location = new System.Drawing.Point(456, 225);
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
            this.lbl_inprocess.Location = new System.Drawing.Point(149, 484);
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
            this.lbl_resolved.Location = new System.Drawing.Point(456, 484);
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
            this.lbl_urgent.Location = new System.Drawing.Point(20, 51);
            this.lbl_urgent.Name = "lbl_urgent";
            this.lbl_urgent.Size = new System.Drawing.Size(72, 27);
            this.lbl_urgent.TabIndex = 0;
            this.lbl_urgent.Text = "Urgent";
            this.lbl_urgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_urgent.Click += new System.EventHandler(this.lbl_urgent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_passdeadline);
            this.groupBox1.Controls.Add(this.lbl_low);
            this.groupBox1.Controls.Add(this.lbl_normal);
            this.groupBox1.Controls.Add(this.lbl_urgent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(645, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 503);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unresolved Tickets";
            // 
            // lbl_passdeadline
            // 
            this.lbl_passdeadline.AutoSize = true;
            this.lbl_passdeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_passdeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_passdeadline.Location = new System.Drawing.Point(20, 358);
            this.lbl_passdeadline.Name = "lbl_passdeadline";
            this.lbl_passdeadline.Size = new System.Drawing.Size(135, 27);
            this.lbl_passdeadline.TabIndex = 3;
            this.lbl_passdeadline.Text = "Past Deadline";
            this.lbl_passdeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_passdeadline.Click += new System.EventHandler(this.lbl_passdeadline_Click);
            // 
            // lbl_low
            // 
            this.lbl_low.AutoSize = true;
            this.lbl_low.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_low.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_low.Location = new System.Drawing.Point(20, 257);
            this.lbl_low.Name = "lbl_low";
            this.lbl_low.Size = new System.Drawing.Size(114, 27);
            this.lbl_low.TabIndex = 2;
            this.lbl_low.Text = "Low Priority";
            this.lbl_low.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_normal
            // 
            this.lbl_normal.AutoSize = true;
            this.lbl_normal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_normal.Location = new System.Drawing.Point(20, 152);
            this.lbl_normal.Name = "lbl_normal";
            this.lbl_normal.Size = new System.Drawing.Size(140, 27);
            this.lbl_normal.TabIndex = 1;
            this.lbl_normal.Text = "Normal Priority";
            this.lbl_normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 666);
            this.Controls.Add(this.lbl_resolved);
            this.Controls.Add(this.lbl_inprocess);
            this.Controls.Add(this.lbl_unresolved);
            this.Controls.Add(this.resolvedChart);
            this.Controls.Add(this.unResolvedChart);
            this.Controls.Add(this.inProcessChart);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.overAllChart);
            this.Controls.Add(this.groupBox1);
            this.Name = "DashBoardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashBoardForm_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_logout, 0);
            this.Controls.SetChildIndex(this.linegrBox, 0);
            this.Controls.SetChildIndex(this.overAllChart, 0);
            this.Controls.SetChildIndex(this.lbl_name, 0);
            this.Controls.SetChildIndex(this.inProcessChart, 0);
            this.Controls.SetChildIndex(this.unResolvedChart, 0);
            this.Controls.SetChildIndex(this.resolvedChart, 0);
            this.Controls.SetChildIndex(this.lbl_unresolved, 0);
            this.Controls.SetChildIndex(this.lbl_inprocess, 0);
            this.Controls.SetChildIndex(this.lbl_resolved, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            ((System.ComponentModel.ISupportInitialize)(this.overAllChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inProcessChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unResolvedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolvedChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart overAllChart;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataVisualization.Charting.Chart inProcessChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart unResolvedChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart resolvedChart;
        private System.Windows.Forms.Label lbl_unresolved;
        private System.Windows.Forms.Label lbl_inprocess;
        private System.Windows.Forms.Label lbl_resolved;
        private System.Windows.Forms.Label lbl_urgent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_low;
        private System.Windows.Forms.Label lbl_normal;
        private System.Windows.Forms.Label lbl_passdeadline;
    }
}