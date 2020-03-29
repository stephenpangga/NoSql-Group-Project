namespace NosqlUI
{
    partial class IncidentReport
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
            this.incidentDate_lbl = new System.Windows.Forms.Label();
            this.incidentSubject_lbl = new System.Windows.Forms.Label();
            this.incidentType_lbl = new System.Windows.Forms.Label();
            this.íncidentUser_lbl = new System.Windows.Forms.Label();
            this.incidentPriority_lbl = new System.Windows.Forms.Label();
            this.incidentDeadline_lbl = new System.Windows.Forms.Label();
            this.incidentDescription_lbl = new System.Windows.Forms.Label();
            this.incidentType_cbx = new System.Windows.Forms.ComboBox();
            this.incidentUser_cbx = new System.Windows.Forms.ComboBox();
            this.incidentPriority_cbx = new System.Windows.Forms.ComboBox();
            this.incidentDeadline_cbx = new System.Windows.Forms.ComboBox();
            this.incidentSubject_txtbx = new System.Windows.Forms.TextBox();
            this.incidentDescription_rtxtbx = new System.Windows.Forms.RichTextBox();
            this.incidentCancel_btn = new System.Windows.Forms.Button();
            this.incidentSubmit_btn = new System.Windows.Forms.Button();
            this.incidentReportTitle_lbl = new System.Windows.Forms.Label();
            this.incidentDate_dtp = new System.Windows.Forms.DateTimePicker();
            this.incidentSubType_cbx = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_dash
            // 
            //this.btn_dash.Location = new System.Drawing.Point(14, 14);
            //this.btn_dash.Margin = new System.Windows.Forms.Padding(5);
            //this.btn_dash.Size = new System.Drawing.Size(211, 74);
            // 
            // btn_incident
            // 
            //this.btn_incident.Location = new System.Drawing.Point(253, 14);
            //this.btn_incident.Margin = new System.Windows.Forms.Padding(5);
            //this.btn_incident.Size = new System.Drawing.Size(211, 74);
            // 
            // btn_userM
            // 
            //this.btn_userM.Location = new System.Drawing.Point(499, 14);
            //this.btn_userM.Margin = new System.Windows.Forms.Padding(5);
            //this.btn_userM.Size = new System.Drawing.Size(211, 74);
            // 
            // incidentDate_lbl
            // 
            this.incidentDate_lbl.AutoSize = true;
            this.incidentDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDate_lbl.Location = new System.Drawing.Point(67, 236);
            this.incidentDate_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentDate_lbl.Name = "incidentDate_lbl";
            this.incidentDate_lbl.Size = new System.Drawing.Size(154, 20);
            this.incidentDate_lbl.TabIndex = 3;
            this.incidentDate_lbl.Text = "Data/time reported:";
            // 
            // incidentSubject_lbl
            // 
            this.incidentSubject_lbl.AutoSize = true;
            this.incidentSubject_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentSubject_lbl.Location = new System.Drawing.Point(67, 276);
            this.incidentSubject_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentSubject_lbl.Name = "incidentSubject_lbl";
            this.incidentSubject_lbl.Size = new System.Drawing.Size(152, 20);
            this.incidentSubject_lbl.TabIndex = 4;
            this.incidentSubject_lbl.Text = "Subject of incident:";
            // 
            // incidentType_lbl
            // 
            this.incidentType_lbl.AutoSize = true;
            this.incidentType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentType_lbl.Location = new System.Drawing.Point(67, 318);
            this.incidentType_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentType_lbl.Name = "incidentType_lbl";
            this.incidentType_lbl.Size = new System.Drawing.Size(132, 20);
            this.incidentType_lbl.TabIndex = 5;
            this.incidentType_lbl.Text = "Type of incident:";
            // 
            // íncidentUser_lbl
            // 
            this.íncidentUser_lbl.AutoSize = true;
            this.íncidentUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.íncidentUser_lbl.Location = new System.Drawing.Point(67, 418);
            this.íncidentUser_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.íncidentUser_lbl.Name = "íncidentUser_lbl";
            this.íncidentUser_lbl.Size = new System.Drawing.Size(142, 20);
            this.íncidentUser_lbl.TabIndex = 6;
            this.íncidentUser_lbl.Text = "Reported by user:";
            // 
            // incidentPriority_lbl
            // 
            this.incidentPriority_lbl.AutoSize = true;
            this.incidentPriority_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentPriority_lbl.Location = new System.Drawing.Point(67, 457);
            this.incidentPriority_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentPriority_lbl.Name = "incidentPriority_lbl";
            this.incidentPriority_lbl.Size = new System.Drawing.Size(67, 20);
            this.incidentPriority_lbl.TabIndex = 7;
            this.incidentPriority_lbl.Text = "Priority:";
            // 
            // incidentDeadline_lbl
            // 
            this.incidentDeadline_lbl.AutoSize = true;
            this.incidentDeadline_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDeadline_lbl.Location = new System.Drawing.Point(67, 496);
            this.incidentDeadline_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentDeadline_lbl.Name = "incidentDeadline_lbl";
            this.incidentDeadline_lbl.Size = new System.Drawing.Size(151, 20);
            this.incidentDeadline_lbl.TabIndex = 8;
            this.incidentDeadline_lbl.Text = "Deadline/follow up:";
            // 
            // incidentDescription_lbl
            // 
            this.incidentDescription_lbl.AutoSize = true;
            this.incidentDescription_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDescription_lbl.Location = new System.Drawing.Point(67, 535);
            this.incidentDescription_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentDescription_lbl.Name = "incidentDescription_lbl";
            this.incidentDescription_lbl.Size = new System.Drawing.Size(100, 20);
            this.incidentDescription_lbl.TabIndex = 9;
            this.incidentDescription_lbl.Text = "Description:";
            // 
            // incidentType_cbx
            // 
            this.incidentType_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentType_cbx.FormattingEnabled = true;
            this.incidentType_cbx.Location = new System.Drawing.Point(285, 318);
            this.incidentType_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentType_cbx.Name = "incidentType_cbx";
            this.incidentType_cbx.Size = new System.Drawing.Size(462, 28);
            this.incidentType_cbx.TabIndex = 10;
            this.incidentType_cbx.Text = "Select type";
            this.incidentType_cbx.SelectedIndexChanged += new System.EventHandler(this.incidentType_cbx_SelectedIndexChanged);
            // 
            // incidentUser_cbx
            // 
            this.incidentUser_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentUser_cbx.FormattingEnabled = true;
            this.incidentUser_cbx.Location = new System.Drawing.Point(285, 418);
            this.incidentUser_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentUser_cbx.Name = "incidentUser_cbx";
            this.incidentUser_cbx.Size = new System.Drawing.Size(462, 28);
            this.incidentUser_cbx.TabIndex = 11;
            // 
            // incidentPriority_cbx
            // 
            this.incidentPriority_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentPriority_cbx.FormattingEnabled = true;
            this.incidentPriority_cbx.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.incidentPriority_cbx.Location = new System.Drawing.Point(285, 457);
            this.incidentPriority_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentPriority_cbx.Name = "incidentPriority_cbx";
            this.incidentPriority_cbx.Size = new System.Drawing.Size(462, 28);
            this.incidentPriority_cbx.TabIndex = 12;
            // 
            // incidentDeadline_cbx
            // 
            this.incidentDeadline_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDeadline_cbx.FormattingEnabled = true;
            this.incidentDeadline_cbx.Items.AddRange(new object[] {
            "7 days",
            "14 days",
            "28 days",
            "6 months"});
            this.incidentDeadline_cbx.Location = new System.Drawing.Point(285, 496);
            this.incidentDeadline_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentDeadline_cbx.Name = "incidentDeadline_cbx";
            this.incidentDeadline_cbx.Size = new System.Drawing.Size(462, 28);
            this.incidentDeadline_cbx.TabIndex = 13;
            // 
            // incidentSubject_txtbx
            // 
            this.incidentSubject_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentSubject_txtbx.Location = new System.Drawing.Point(285, 276);
            this.incidentSubject_txtbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentSubject_txtbx.Name = "incidentSubject_txtbx";
            this.incidentSubject_txtbx.Size = new System.Drawing.Size(462, 26);
            this.incidentSubject_txtbx.TabIndex = 14;
            // 
            // incidentDescription_rtxtbx
            // 
            this.incidentDescription_rtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDescription_rtxtbx.Location = new System.Drawing.Point(285, 535);
            this.incidentDescription_rtxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentDescription_rtxtbx.Name = "incidentDescription_rtxtbx";
            this.incidentDescription_rtxtbx.Size = new System.Drawing.Size(462, 226);
            this.incidentDescription_rtxtbx.TabIndex = 15;
            this.incidentDescription_rtxtbx.Text = "";
            // 
            // incidentCancel_btn
            // 
            this.incidentCancel_btn.Location = new System.Drawing.Point(285, 796);
            this.incidentCancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentCancel_btn.Name = "incidentCancel_btn";
            this.incidentCancel_btn.Size = new System.Drawing.Size(219, 53);
            this.incidentCancel_btn.TabIndex = 17;
            this.incidentCancel_btn.Text = "CANCEL";
            this.incidentCancel_btn.UseVisualStyleBackColor = true;
            // 
            // incidentSubmit_btn
            // 
            this.incidentSubmit_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentSubmit_btn.Location = new System.Drawing.Point(529, 796);
            this.incidentSubmit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentSubmit_btn.Name = "incidentSubmit_btn";
            this.incidentSubmit_btn.Size = new System.Drawing.Size(219, 53);
            this.incidentSubmit_btn.TabIndex = 18;
            this.incidentSubmit_btn.Text = "SUBMIT TICKET";
            this.incidentSubmit_btn.UseVisualStyleBackColor = false;
            this.incidentSubmit_btn.Click += new System.EventHandler(this.incidentSubmit_btn_Click);
            // 
            // incidentReportTitle_lbl
            // 
            this.incidentReportTitle_lbl.AutoSize = true;
            this.incidentReportTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentReportTitle_lbl.Location = new System.Drawing.Point(67, 154);
            this.incidentReportTitle_lbl.Name = "incidentReportTitle_lbl";
            this.incidentReportTitle_lbl.Size = new System.Drawing.Size(375, 33);
            this.incidentReportTitle_lbl.TabIndex = 19;
            this.incidentReportTitle_lbl.Text = "Create new incident ticket";
            // 
            // incidentDate_dtp
            // 
            this.incidentDate_dtp.Location = new System.Drawing.Point(285, 236);
            this.incidentDate_dtp.Name = "incidentDate_dtp";
            this.incidentDate_dtp.Size = new System.Drawing.Size(462, 26);
            this.incidentDate_dtp.TabIndex = 20;
            // 
            // incidentSubType_cbx
            // 
            this.incidentSubType_cbx.FormattingEnabled = true;
            this.incidentSubType_cbx.Location = new System.Drawing.Point(285, 354);
            this.incidentSubType_cbx.Name = "incidentSubType_cbx";
            this.incidentSubType_cbx.Size = new System.Drawing.Size(463, 28);
            this.incidentSubType_cbx.TabIndex = 21;
            this.incidentSubType_cbx.Text = "Select Secondary Type";
            // 
            // IncidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 901);
            this.Controls.Add(this.incidentSubType_cbx);
            this.Controls.Add(this.incidentDate_dtp);
            this.Controls.Add(this.incidentReportTitle_lbl);
            this.Controls.Add(this.incidentSubmit_btn);
            this.Controls.Add(this.incidentCancel_btn);
            this.Controls.Add(this.incidentDescription_rtxtbx);
            this.Controls.Add(this.incidentSubject_txtbx);
            this.Controls.Add(this.incidentDeadline_cbx);
            this.Controls.Add(this.incidentPriority_cbx);
            this.Controls.Add(this.incidentUser_cbx);
            this.Controls.Add(this.incidentType_cbx);
            this.Controls.Add(this.incidentDescription_lbl);
            this.Controls.Add(this.incidentDeadline_lbl);
            this.Controls.Add(this.incidentPriority_lbl);
            this.Controls.Add(this.íncidentUser_lbl);
            this.Controls.Add(this.incidentType_lbl);
            this.Controls.Add(this.incidentSubject_lbl);
            this.Controls.Add(this.incidentDate_lbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "IncidentReport";
            this.Text = "IncidentReport";
            this.Controls.SetChildIndex(this.incidentDate_lbl, 0);
            this.Controls.SetChildIndex(this.incidentSubject_lbl, 0);
            this.Controls.SetChildIndex(this.incidentType_lbl, 0);
            this.Controls.SetChildIndex(this.íncidentUser_lbl, 0);
            this.Controls.SetChildIndex(this.incidentPriority_lbl, 0);
            this.Controls.SetChildIndex(this.incidentDeadline_lbl, 0);
            this.Controls.SetChildIndex(this.incidentDescription_lbl, 0);
            this.Controls.SetChildIndex(this.incidentType_cbx, 0);
            this.Controls.SetChildIndex(this.incidentUser_cbx, 0);
            this.Controls.SetChildIndex(this.incidentPriority_cbx, 0);
            this.Controls.SetChildIndex(this.incidentDeadline_cbx, 0);
            this.Controls.SetChildIndex(this.incidentSubject_txtbx, 0);
            this.Controls.SetChildIndex(this.incidentDescription_rtxtbx, 0);
            this.Controls.SetChildIndex(this.incidentCancel_btn, 0);
            //this.Controls.SetChildIndex(this.btn_dash, 0);
            //this.Controls.SetChildIndex(this.btn_incident, 0);
            //this.Controls.SetChildIndex(this.btn_userM, 0);
            this.Controls.SetChildIndex(this.incidentSubmit_btn, 0);
            this.Controls.SetChildIndex(this.incidentReportTitle_lbl, 0);
            this.Controls.SetChildIndex(this.incidentDate_dtp, 0);
            this.Controls.SetChildIndex(this.incidentSubType_cbx, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incidentDate_lbl;
        private System.Windows.Forms.Label incidentSubject_lbl;
        private System.Windows.Forms.Label incidentType_lbl;
        private System.Windows.Forms.Label íncidentUser_lbl;
        private System.Windows.Forms.Label incidentPriority_lbl;
        private System.Windows.Forms.Label incidentDeadline_lbl;
        private System.Windows.Forms.Label incidentDescription_lbl;
        private System.Windows.Forms.ComboBox incidentType_cbx;
        private System.Windows.Forms.ComboBox incidentUser_cbx;
        private System.Windows.Forms.ComboBox incidentPriority_cbx;
        private System.Windows.Forms.ComboBox incidentDeadline_cbx;
        private System.Windows.Forms.TextBox incidentSubject_txtbx;
        private System.Windows.Forms.RichTextBox incidentDescription_rtxtbx;
        private System.Windows.Forms.Button incidentCancel_btn;
        private System.Windows.Forms.Button incidentSubmit_btn;
        private System.Windows.Forms.Label incidentReportTitle_lbl;
        private System.Windows.Forms.DateTimePicker incidentDate_dtp;
        private System.Windows.Forms.ComboBox incidentSubType_cbx;
    }
}