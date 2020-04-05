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
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(20, 11);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dashboard.Size = new System.Drawing.Size(142, 26);
            this.btn_Dashboard.Visible = false;
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(168, 11);
            this.btn_IncidentM.Margin = new System.Windows.Forms.Padding(2);
            this.btn_IncidentM.Size = new System.Drawing.Size(142, 26);
            this.btn_IncidentM.Visible = false;
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(315, 11);
            this.btn_UserM.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UserM.Size = new System.Drawing.Size(142, 26);
            this.btn_UserM.Visible = false;
            // 
            // linegrBox
            // 
            this.linegrBox.Location = new System.Drawing.Point(17, 49);
            this.linegrBox.Margin = new System.Windows.Forms.Padding(2);
            this.linegrBox.Padding = new System.Windows.Forms.Padding(2);
            this.linegrBox.Size = new System.Drawing.Size(678, 10);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(595, 11);
            this.btn_logout.Size = new System.Drawing.Size(99, 26);
            this.btn_logout.Visible = false;
            // 
            // incidentDate_lbl
            // 
            this.incidentDate_lbl.AutoSize = true;
            this.incidentDate_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDate_lbl.Location = new System.Drawing.Point(14, 133);
            this.incidentDate_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentDate_lbl.Name = "incidentDate_lbl";
            this.incidentDate_lbl.Size = new System.Drawing.Size(130, 17);
            this.incidentDate_lbl.TabIndex = 3;
            this.incidentDate_lbl.Text = "Data/time reported:";
            // 
            // incidentSubject_lbl
            // 
            this.incidentSubject_lbl.AutoSize = true;
            this.incidentSubject_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentSubject_lbl.Location = new System.Drawing.Point(14, 173);
            this.incidentSubject_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentSubject_lbl.Name = "incidentSubject_lbl";
            this.incidentSubject_lbl.Size = new System.Drawing.Size(128, 17);
            this.incidentSubject_lbl.TabIndex = 4;
            this.incidentSubject_lbl.Text = "Subject of incident:";
            // 
            // incidentType_lbl
            // 
            this.incidentType_lbl.AutoSize = true;
            this.incidentType_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentType_lbl.Location = new System.Drawing.Point(14, 215);
            this.incidentType_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentType_lbl.Name = "incidentType_lbl";
            this.incidentType_lbl.Size = new System.Drawing.Size(113, 17);
            this.incidentType_lbl.TabIndex = 5;
            this.incidentType_lbl.Text = "Type of incident:";
            // 
            // íncidentUser_lbl
            // 
            this.íncidentUser_lbl.AutoSize = true;
            this.íncidentUser_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.íncidentUser_lbl.Location = new System.Drawing.Point(14, 315);
            this.íncidentUser_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.íncidentUser_lbl.Name = "íncidentUser_lbl";
            this.íncidentUser_lbl.Size = new System.Drawing.Size(122, 17);
            this.íncidentUser_lbl.TabIndex = 6;
            this.íncidentUser_lbl.Text = "Reported by user:";
            // 
            // incidentPriority_lbl
            // 
            this.incidentPriority_lbl.AutoSize = true;
            this.incidentPriority_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentPriority_lbl.Location = new System.Drawing.Point(14, 354);
            this.incidentPriority_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentPriority_lbl.Name = "incidentPriority_lbl";
            this.incidentPriority_lbl.Size = new System.Drawing.Size(56, 17);
            this.incidentPriority_lbl.TabIndex = 7;
            this.incidentPriority_lbl.Text = "Priority:";
            // 
            // incidentDeadline_lbl
            // 
            this.incidentDeadline_lbl.AutoSize = true;
            this.incidentDeadline_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDeadline_lbl.Location = new System.Drawing.Point(14, 393);
            this.incidentDeadline_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentDeadline_lbl.Name = "incidentDeadline_lbl";
            this.incidentDeadline_lbl.Size = new System.Drawing.Size(127, 17);
            this.incidentDeadline_lbl.TabIndex = 8;
            this.incidentDeadline_lbl.Text = "Deadline/follow up:";
            // 
            // incidentDescription_lbl
            // 
            this.incidentDescription_lbl.AutoSize = true;
            this.incidentDescription_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDescription_lbl.Location = new System.Drawing.Point(14, 432);
            this.incidentDescription_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incidentDescription_lbl.Name = "incidentDescription_lbl";
            this.incidentDescription_lbl.Size = new System.Drawing.Size(83, 17);
            this.incidentDescription_lbl.TabIndex = 9;
            this.incidentDescription_lbl.Text = "Description:";
            // 
            // incidentType_cbx
            // 
            this.incidentType_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentType_cbx.FormattingEnabled = true;
            this.incidentType_cbx.Location = new System.Drawing.Point(232, 215);
            this.incidentType_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentType_cbx.Name = "incidentType_cbx";
            this.incidentType_cbx.Size = new System.Drawing.Size(462, 24);
            this.incidentType_cbx.TabIndex = 10;
            this.incidentType_cbx.Text = "Select type";
            this.incidentType_cbx.SelectedIndexChanged += new System.EventHandler(this.incidentType_cbx_SelectedIndexChanged);
            // 
            // incidentUser_cbx
            // 
            this.incidentUser_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentUser_cbx.FormattingEnabled = true;
            this.incidentUser_cbx.Location = new System.Drawing.Point(232, 315);
            this.incidentUser_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentUser_cbx.Name = "incidentUser_cbx";
            this.incidentUser_cbx.Size = new System.Drawing.Size(462, 24);
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
            this.incidentPriority_cbx.Location = new System.Drawing.Point(232, 354);
            this.incidentPriority_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentPriority_cbx.Name = "incidentPriority_cbx";
            this.incidentPriority_cbx.Size = new System.Drawing.Size(462, 24);
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
            this.incidentDeadline_cbx.Location = new System.Drawing.Point(232, 393);
            this.incidentDeadline_cbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentDeadline_cbx.Name = "incidentDeadline_cbx";
            this.incidentDeadline_cbx.Size = new System.Drawing.Size(462, 24);
            this.incidentDeadline_cbx.TabIndex = 13;
            // 
            // incidentSubject_txtbx
            // 
            this.incidentSubject_txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentSubject_txtbx.Location = new System.Drawing.Point(232, 173);
            this.incidentSubject_txtbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentSubject_txtbx.Name = "incidentSubject_txtbx";
            this.incidentSubject_txtbx.Size = new System.Drawing.Size(462, 23);
            this.incidentSubject_txtbx.TabIndex = 14;
            // 
            // incidentDescription_rtxtbx
            // 
            this.incidentDescription_rtxtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentDescription_rtxtbx.Location = new System.Drawing.Point(232, 432);
            this.incidentDescription_rtxtbx.Margin = new System.Windows.Forms.Padding(4);
            this.incidentDescription_rtxtbx.Name = "incidentDescription_rtxtbx";
            this.incidentDescription_rtxtbx.Size = new System.Drawing.Size(462, 226);
            this.incidentDescription_rtxtbx.TabIndex = 15;
            this.incidentDescription_rtxtbx.Text = "";
            // 
            // incidentCancel_btn
            // 
            this.incidentCancel_btn.Location = new System.Drawing.Point(232, 693);
            this.incidentCancel_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentCancel_btn.Name = "incidentCancel_btn";
            this.incidentCancel_btn.Size = new System.Drawing.Size(219, 53);
            this.incidentCancel_btn.TabIndex = 17;
            this.incidentCancel_btn.Text = "CANCEL";
            this.incidentCancel_btn.UseVisualStyleBackColor = true;
            this.incidentCancel_btn.Click += new System.EventHandler(this.incidentCancel_btn_Click);
            // 
            // incidentSubmit_btn
            // 
            this.incidentSubmit_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentSubmit_btn.Location = new System.Drawing.Point(476, 693);
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
            this.incidentReportTitle_lbl.Location = new System.Drawing.Point(14, 51);
            this.incidentReportTitle_lbl.Name = "incidentReportTitle_lbl";
            this.incidentReportTitle_lbl.Size = new System.Drawing.Size(314, 29);
            this.incidentReportTitle_lbl.TabIndex = 19;
            this.incidentReportTitle_lbl.Text = "Create new incident ticket";
            // 
            // incidentDate_dtp
            // 
            this.incidentDate_dtp.Location = new System.Drawing.Point(232, 133);
            this.incidentDate_dtp.Name = "incidentDate_dtp";
            this.incidentDate_dtp.Size = new System.Drawing.Size(462, 23);
            this.incidentDate_dtp.TabIndex = 20;
            // 
            // incidentSubType_cbx
            // 
            this.incidentSubType_cbx.FormattingEnabled = true;
            this.incidentSubType_cbx.Location = new System.Drawing.Point(232, 251);
            this.incidentSubType_cbx.Name = "incidentSubType_cbx";
            this.incidentSubType_cbx.Size = new System.Drawing.Size(463, 24);
            this.incidentSubType_cbx.TabIndex = 21;
            this.incidentSubType_cbx.Text = "Select Secondary Type";
            // 
            // IncidentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 765);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IncidentReport_FormClosed);
            this.Controls.SetChildIndex(this.btn_logout, 0);
            this.Controls.SetChildIndex(this.linegrBox, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
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