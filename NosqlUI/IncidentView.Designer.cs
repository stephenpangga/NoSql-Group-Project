namespace NosqlUI
{
    partial class IncidentManagment
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
            this.incident_lstvw = new System.Windows.Forms.ListView();
            this.incidentViewTitle_lbl = new System.Windows.Forms.Label();
            this.incidentCreate_btn = new System.Windows.Forms.Button();
            this.incidentDescription_rtbx = new System.Windows.Forms.RichTextBox();
            this.incidentDescription_lbl = new System.Windows.Forms.Label();
            this.incidentDelete_btn = new System.Windows.Forms.Button();
            this.incidentUpdate_btn = new System.Windows.Forms.Button();
            this.incidentStatus_cbx = new System.Windows.Forms.ComboBox();
            this.incidentPriority_cbx = new System.Windows.Forms.ComboBox();
            this.incidentMain_tbx = new System.Windows.Forms.TextBox();
            this.incidentSub_tbx = new System.Windows.Forms.TextBox();
            this.incidentCategory_lbl = new System.Windows.Forms.Label();
            this.incidentStatus_lbl = new System.Windows.Forms.Label();
            this.Priority_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resolvedIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.UnresolvedIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.InProcessIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.urgentIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.pastDeadline_ckbx = new System.Windows.Forms.CheckBox();
            this.filter_gpbx = new System.Windows.Forms.GroupBox();
            this.hardwareIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.softwareIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.serviceIncident_ckbx = new System.Windows.Forms.CheckBox();
            this.filter_gpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(241, 32);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(426, 32);
            this.btn_IncidentM.Margin = new System.Windows.Forms.Padding(2);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(610, 32);
            this.btn_UserM.Margin = new System.Windows.Forms.Padding(2);
            // 
            // linegrBox
            // 
            this.linegrBox.Location = new System.Drawing.Point(20, 95);
            this.linegrBox.Margin = new System.Windows.Forms.Padding(4);
            this.linegrBox.Padding = new System.Windows.Forms.Padding(4);
            this.linegrBox.Size = new System.Drawing.Size(975, 10);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(922, 32);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // incident_lstvw
            // 
            this.incident_lstvw.FullRowSelect = true;
            this.incident_lstvw.HideSelection = false;
            this.incident_lstvw.Location = new System.Drawing.Point(20, 212);
            this.incident_lstvw.Margin = new System.Windows.Forms.Padding(2);
            this.incident_lstvw.Name = "incident_lstvw";
            this.incident_lstvw.Size = new System.Drawing.Size(608, 364);
            this.incident_lstvw.TabIndex = 3;
            this.incident_lstvw.UseCompatibleStateImageBehavior = false;
            this.incident_lstvw.SelectedIndexChanged += new System.EventHandler(this.incident_lstvw_SelectedIndexChanged);
            // 
            // incidentViewTitle_lbl
            // 
            this.incidentViewTitle_lbl.AutoSize = true;
            this.incidentViewTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentViewTitle_lbl.Location = new System.Drawing.Point(24, 63);
            this.incidentViewTitle_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incidentViewTitle_lbl.Name = "incidentViewTitle_lbl";
            this.incidentViewTitle_lbl.Size = new System.Drawing.Size(198, 29);
            this.incidentViewTitle_lbl.TabIndex = 4;
            this.incidentViewTitle_lbl.Text = "Overview Tickets";
            // 
            // incidentCreate_btn
            // 
            this.incidentCreate_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentCreate_btn.Location = new System.Drawing.Point(463, 161);
            this.incidentCreate_btn.Name = "incidentCreate_btn";
            this.incidentCreate_btn.Size = new System.Drawing.Size(164, 43);
            this.incidentCreate_btn.TabIndex = 19;
            this.incidentCreate_btn.Text = "CREATE INCIDENT";
            this.incidentCreate_btn.UseVisualStyleBackColor = false;
            this.incidentCreate_btn.Click += new System.EventHandler(this.incidentCreate_btn_Click);
            // 
            // incidentDescription_rtbx
            // 
            this.incidentDescription_rtbx.Location = new System.Drawing.Point(660, 363);
            this.incidentDescription_rtbx.Margin = new System.Windows.Forms.Padding(2);
            this.incidentDescription_rtbx.Name = "incidentDescription_rtbx";
            this.incidentDescription_rtbx.Size = new System.Drawing.Size(314, 154);
            this.incidentDescription_rtbx.TabIndex = 20;
            this.incidentDescription_rtbx.Text = "";
            // 
            // incidentDescription_lbl
            // 
            this.incidentDescription_lbl.AutoSize = true;
            this.incidentDescription_lbl.Location = new System.Drawing.Point(660, 339);
            this.incidentDescription_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incidentDescription_lbl.Name = "incidentDescription_lbl";
            this.incidentDescription_lbl.Size = new System.Drawing.Size(63, 13);
            this.incidentDescription_lbl.TabIndex = 21;
            this.incidentDescription_lbl.Text = "Description:";
            // 
            // incidentDelete_btn
            // 
            this.incidentDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.incidentDelete_btn.Location = new System.Drawing.Point(660, 533);
            this.incidentDelete_btn.Name = "incidentDelete_btn";
            this.incidentDelete_btn.Size = new System.Drawing.Size(157, 43);
            this.incidentDelete_btn.TabIndex = 22;
            this.incidentDelete_btn.Text = "DELETE INCIDENT";
            this.incidentDelete_btn.UseVisualStyleBackColor = false;
            this.incidentDelete_btn.Click += new System.EventHandler(this.incidentDelete_btn_Click);
            // 
            // incidentUpdate_btn
            // 
            this.incidentUpdate_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentUpdate_btn.Location = new System.Drawing.Point(823, 534);
            this.incidentUpdate_btn.Name = "incidentUpdate_btn";
            this.incidentUpdate_btn.Size = new System.Drawing.Size(151, 43);
            this.incidentUpdate_btn.TabIndex = 23;
            this.incidentUpdate_btn.Text = "UPDATE INCIDENT";
            this.incidentUpdate_btn.UseVisualStyleBackColor = false;
            this.incidentUpdate_btn.Click += new System.EventHandler(this.incidentUpdate_btn_Click);
            // 
            // incidentStatus_cbx
            // 
            this.incidentStatus_cbx.FormattingEnabled = true;
            this.incidentStatus_cbx.Location = new System.Drawing.Point(794, 185);
            this.incidentStatus_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.incidentStatus_cbx.Name = "incidentStatus_cbx";
            this.incidentStatus_cbx.Size = new System.Drawing.Size(180, 21);
            this.incidentStatus_cbx.TabIndex = 24;
            // 
            // incidentPriority_cbx
            // 
            this.incidentPriority_cbx.FormattingEnabled = true;
            this.incidentPriority_cbx.Location = new System.Drawing.Point(794, 212);
            this.incidentPriority_cbx.Margin = new System.Windows.Forms.Padding(2);
            this.incidentPriority_cbx.Name = "incidentPriority_cbx";
            this.incidentPriority_cbx.Size = new System.Drawing.Size(180, 21);
            this.incidentPriority_cbx.TabIndex = 25;
            // 
            // incidentMain_tbx
            // 
            this.incidentMain_tbx.Enabled = false;
            this.incidentMain_tbx.Location = new System.Drawing.Point(794, 277);
            this.incidentMain_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.incidentMain_tbx.Name = "incidentMain_tbx";
            this.incidentMain_tbx.Size = new System.Drawing.Size(180, 20);
            this.incidentMain_tbx.TabIndex = 26;
            // 
            // incidentSub_tbx
            // 
            this.incidentSub_tbx.Enabled = false;
            this.incidentSub_tbx.Location = new System.Drawing.Point(660, 301);
            this.incidentSub_tbx.Margin = new System.Windows.Forms.Padding(2);
            this.incidentSub_tbx.Name = "incidentSub_tbx";
            this.incidentSub_tbx.Size = new System.Drawing.Size(314, 20);
            this.incidentSub_tbx.TabIndex = 27;
            // 
            // incidentCategory_lbl
            // 
            this.incidentCategory_lbl.AutoSize = true;
            this.incidentCategory_lbl.Location = new System.Drawing.Point(657, 280);
            this.incidentCategory_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incidentCategory_lbl.Name = "incidentCategory_lbl";
            this.incidentCategory_lbl.Size = new System.Drawing.Size(52, 13);
            this.incidentCategory_lbl.TabIndex = 28;
            this.incidentCategory_lbl.Text = "Category:";
            // 
            // incidentStatus_lbl
            // 
            this.incidentStatus_lbl.AutoSize = true;
            this.incidentStatus_lbl.Location = new System.Drawing.Point(657, 193);
            this.incidentStatus_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incidentStatus_lbl.Name = "incidentStatus_lbl";
            this.incidentStatus_lbl.Size = new System.Drawing.Size(37, 13);
            this.incidentStatus_lbl.TabIndex = 30;
            this.incidentStatus_lbl.Text = "Satus:";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Location = new System.Drawing.Point(657, 220);
            this.Priority_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(41, 13);
            this.Priority_lbl.TabIndex = 32;
            this.Priority_lbl.Text = "Priority:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(646, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 453);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Information";
            // 
            // resolvedIncident_ckbx
            // 
            this.resolvedIncident_ckbx.AutoSize = true;
            this.resolvedIncident_ckbx.Location = new System.Drawing.Point(8, 58);
            this.resolvedIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.resolvedIncident_ckbx.Name = "resolvedIncident_ckbx";
            this.resolvedIncident_ckbx.Size = new System.Drawing.Size(71, 17);
            this.resolvedIncident_ckbx.TabIndex = 34;
            this.resolvedIncident_ckbx.Text = "Resolved";
            this.resolvedIncident_ckbx.UseVisualStyleBackColor = true;
            this.resolvedIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // UnresolvedIncident_ckbx
            // 
            this.UnresolvedIncident_ckbx.AutoSize = true;
            this.UnresolvedIncident_ckbx.Location = new System.Drawing.Point(166, 58);
            this.UnresolvedIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.UnresolvedIncident_ckbx.Name = "UnresolvedIncident_ckbx";
            this.UnresolvedIncident_ckbx.Size = new System.Drawing.Size(80, 17);
            this.UnresolvedIncident_ckbx.TabIndex = 35;
            this.UnresolvedIncident_ckbx.Text = "Unresolved";
            this.UnresolvedIncident_ckbx.UseVisualStyleBackColor = true;
            this.UnresolvedIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // InProcessIncident_ckbx
            // 
            this.InProcessIncident_ckbx.AutoSize = true;
            this.InProcessIncident_ckbx.Location = new System.Drawing.Point(88, 58);
            this.InProcessIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.InProcessIncident_ckbx.Name = "InProcessIncident_ckbx";
            this.InProcessIncident_ckbx.Size = new System.Drawing.Size(76, 17);
            this.InProcessIncident_ckbx.TabIndex = 36;
            this.InProcessIncident_ckbx.Text = "In Process";
            this.InProcessIncident_ckbx.UseVisualStyleBackColor = true;
            this.InProcessIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // urgentIncident_ckbx
            // 
            this.urgentIncident_ckbx.AutoSize = true;
            this.urgentIncident_ckbx.Location = new System.Drawing.Point(294, 58);
            this.urgentIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.urgentIncident_ckbx.Name = "urgentIncident_ckbx";
            this.urgentIncident_ckbx.Size = new System.Drawing.Size(58, 17);
            this.urgentIncident_ckbx.TabIndex = 37;
            this.urgentIncident_ckbx.Text = "Urgent";
            this.urgentIncident_ckbx.UseVisualStyleBackColor = true;
            this.urgentIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // pastDeadline_ckbx
            // 
            this.pastDeadline_ckbx.AutoSize = true;
            this.pastDeadline_ckbx.Location = new System.Drawing.Point(294, 37);
            this.pastDeadline_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.pastDeadline_ckbx.Name = "pastDeadline_ckbx";
            this.pastDeadline_ckbx.Size = new System.Drawing.Size(92, 17);
            this.pastDeadline_ckbx.TabIndex = 38;
            this.pastDeadline_ckbx.Text = "Past Deadline";
            this.pastDeadline_ckbx.UseVisualStyleBackColor = true;
            this.pastDeadline_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // filter_gpbx
            // 
            this.filter_gpbx.Controls.Add(this.hardwareIncident_ckbx);
            this.filter_gpbx.Controls.Add(this.softwareIncident_ckbx);
            this.filter_gpbx.Controls.Add(this.serviceIncident_ckbx);
            this.filter_gpbx.Controls.Add(this.pastDeadline_ckbx);
            this.filter_gpbx.Controls.Add(this.resolvedIncident_ckbx);
            this.filter_gpbx.Controls.Add(this.urgentIncident_ckbx);
            this.filter_gpbx.Controls.Add(this.UnresolvedIncident_ckbx);
            this.filter_gpbx.Controls.Add(this.InProcessIncident_ckbx);
            this.filter_gpbx.Location = new System.Drawing.Point(28, 124);
            this.filter_gpbx.Margin = new System.Windows.Forms.Padding(2);
            this.filter_gpbx.Name = "filter_gpbx";
            this.filter_gpbx.Padding = new System.Windows.Forms.Padding(2);
            this.filter_gpbx.Size = new System.Drawing.Size(416, 81);
            this.filter_gpbx.TabIndex = 39;
            this.filter_gpbx.TabStop = false;
            this.filter_gpbx.Text = "Filter";
            // 
            // hardwareIncident_ckbx
            // 
            this.hardwareIncident_ckbx.AutoSize = true;
            this.hardwareIncident_ckbx.Location = new System.Drawing.Point(8, 24);
            this.hardwareIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.hardwareIncident_ckbx.Name = "hardwareIncident_ckbx";
            this.hardwareIncident_ckbx.Size = new System.Drawing.Size(72, 17);
            this.hardwareIncident_ckbx.TabIndex = 39;
            this.hardwareIncident_ckbx.Text = "Hardware";
            this.hardwareIncident_ckbx.UseVisualStyleBackColor = true;
            this.hardwareIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // softwareIncident_ckbx
            // 
            this.softwareIncident_ckbx.AutoSize = true;
            this.softwareIncident_ckbx.Location = new System.Drawing.Point(88, 24);
            this.softwareIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.softwareIncident_ckbx.Name = "softwareIncident_ckbx";
            this.softwareIncident_ckbx.Size = new System.Drawing.Size(68, 17);
            this.softwareIncident_ckbx.TabIndex = 40;
            this.softwareIncident_ckbx.Text = "Software";
            this.softwareIncident_ckbx.UseVisualStyleBackColor = true;
            this.softwareIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // serviceIncident_ckbx
            // 
            this.serviceIncident_ckbx.AutoSize = true;
            this.serviceIncident_ckbx.Location = new System.Drawing.Point(166, 24);
            this.serviceIncident_ckbx.Margin = new System.Windows.Forms.Padding(2);
            this.serviceIncident_ckbx.Name = "serviceIncident_ckbx";
            this.serviceIncident_ckbx.Size = new System.Drawing.Size(62, 17);
            this.serviceIncident_ckbx.TabIndex = 41;
            this.serviceIncident_ckbx.Text = "Service";
            this.serviceIncident_ckbx.UseVisualStyleBackColor = true;
            this.serviceIncident_ckbx.CheckedChanged += new System.EventHandler(this.Incident_ckbx_CheckedChanged);
            // 
            // IncidentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 597);
            this.Controls.Add(this.filter_gpbx);
            this.Controls.Add(this.Priority_lbl);
            this.Controls.Add(this.incidentStatus_lbl);
            this.Controls.Add(this.incidentCategory_lbl);
            this.Controls.Add(this.incidentSub_tbx);
            this.Controls.Add(this.incidentMain_tbx);
            this.Controls.Add(this.incidentPriority_cbx);
            this.Controls.Add(this.incidentStatus_cbx);
            this.Controls.Add(this.incidentUpdate_btn);
            this.Controls.Add(this.incidentDelete_btn);
            this.Controls.Add(this.incidentDescription_lbl);
            this.Controls.Add(this.incidentDescription_rtbx);
            this.Controls.Add(this.incidentCreate_btn);
            this.Controls.Add(this.incidentViewTitle_lbl);
            this.Controls.Add(this.incident_lstvw);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IncidentManagment";
            this.Text = "Incident Managment";
            this.Controls.SetChildIndex(this.btn_logout, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.linegrBox, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            this.Controls.SetChildIndex(this.incident_lstvw, 0);
            this.Controls.SetChildIndex(this.incidentViewTitle_lbl, 0);
            this.Controls.SetChildIndex(this.incidentCreate_btn, 0);
            this.Controls.SetChildIndex(this.incidentDescription_rtbx, 0);
            this.Controls.SetChildIndex(this.incidentDescription_lbl, 0);
            this.Controls.SetChildIndex(this.incidentDelete_btn, 0);
            this.Controls.SetChildIndex(this.incidentUpdate_btn, 0);
            this.Controls.SetChildIndex(this.incidentStatus_cbx, 0);
            this.Controls.SetChildIndex(this.incidentPriority_cbx, 0);
            this.Controls.SetChildIndex(this.incidentMain_tbx, 0);
            this.Controls.SetChildIndex(this.incidentSub_tbx, 0);
            this.Controls.SetChildIndex(this.incidentCategory_lbl, 0);
            this.Controls.SetChildIndex(this.incidentStatus_lbl, 0);
            this.Controls.SetChildIndex(this.Priority_lbl, 0);
            this.Controls.SetChildIndex(this.filter_gpbx, 0);
            this.filter_gpbx.ResumeLayout(false);
            this.filter_gpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView incident_lstvw;
        private System.Windows.Forms.Label incidentViewTitle_lbl;
        private System.Windows.Forms.Button incidentCreate_btn;
        private System.Windows.Forms.RichTextBox incidentDescription_rtbx;
        private System.Windows.Forms.Label incidentDescription_lbl;
        private System.Windows.Forms.Button incidentDelete_btn;
        private System.Windows.Forms.Button incidentUpdate_btn;
        private System.Windows.Forms.ComboBox incidentStatus_cbx;
        private System.Windows.Forms.ComboBox incidentPriority_cbx;
        private System.Windows.Forms.TextBox incidentMain_tbx;
        private System.Windows.Forms.TextBox incidentSub_tbx;
        private System.Windows.Forms.Label incidentCategory_lbl;
        private System.Windows.Forms.Label incidentStatus_lbl;
        private System.Windows.Forms.Label Priority_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox resolvedIncident_ckbx;
        public System.Windows.Forms.CheckBox UnresolvedIncident_ckbx;
        public System.Windows.Forms.CheckBox InProcessIncident_ckbx;
        public System.Windows.Forms.CheckBox urgentIncident_ckbx;
        public System.Windows.Forms.CheckBox pastDeadline_ckbx;
        private System.Windows.Forms.GroupBox filter_gpbx;
        public System.Windows.Forms.CheckBox hardwareIncident_ckbx;
        public System.Windows.Forms.CheckBox softwareIncident_ckbx;
        public System.Windows.Forms.CheckBox serviceIncident_ckbx;
    }
}