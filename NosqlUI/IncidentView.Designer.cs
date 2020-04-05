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
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(321, 39);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(568, 39);
            this.btn_IncidentM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(813, 39);
            this.btn_UserM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            // 
            // linegrBox
            // 
            this.linegrBox.Location = new System.Drawing.Point(27, 117);
            this.linegrBox.Margin = new System.Windows.Forms.Padding(5);
            this.linegrBox.Padding = new System.Windows.Forms.Padding(5);
            this.linegrBox.Size = new System.Drawing.Size(1300, 12);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(1229, 39);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            // 
            // incident_lstvw
            // 
            this.incident_lstvw.FullRowSelect = true;
            this.incident_lstvw.HideSelection = false;
            this.incident_lstvw.Location = new System.Drawing.Point(27, 229);
            this.incident_lstvw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incident_lstvw.Name = "incident_lstvw";
            this.incident_lstvw.Size = new System.Drawing.Size(809, 480);
            this.incident_lstvw.TabIndex = 3;
            this.incident_lstvw.UseCompatibleStateImageBehavior = false;
            this.incident_lstvw.SelectedIndexChanged += new System.EventHandler(this.incident_lstvw_SelectedIndexChanged);
            // 
            // incidentViewTitle_lbl
            // 
            this.incidentViewTitle_lbl.AutoSize = true;
            this.incidentViewTitle_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentViewTitle_lbl.Location = new System.Drawing.Point(32, 78);
            this.incidentViewTitle_lbl.Name = "incidentViewTitle_lbl";
            this.incidentViewTitle_lbl.Size = new System.Drawing.Size(230, 33);
            this.incidentViewTitle_lbl.TabIndex = 4;
            this.incidentViewTitle_lbl.Text = "Overview tickets";
            // 
            // incidentCreate_btn
            // 
            this.incidentCreate_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentCreate_btn.Location = new System.Drawing.Point(619, 153);
            this.incidentCreate_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentCreate_btn.Name = "incidentCreate_btn";
            this.incidentCreate_btn.Size = new System.Drawing.Size(219, 53);
            this.incidentCreate_btn.TabIndex = 19;
            this.incidentCreate_btn.Text = "CREATE INCIDENT";
            this.incidentCreate_btn.UseVisualStyleBackColor = false;
            this.incidentCreate_btn.Click += new System.EventHandler(this.incidentCreate_btn_Click);
            // 
            // incidentDescription_rtbx
            // 
            this.incidentDescription_rtbx.Location = new System.Drawing.Point(880, 447);
            this.incidentDescription_rtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incidentDescription_rtbx.Name = "incidentDescription_rtbx";
            this.incidentDescription_rtbx.Size = new System.Drawing.Size(417, 189);
            this.incidentDescription_rtbx.TabIndex = 20;
            this.incidentDescription_rtbx.Text = "";
            // 
            // incidentDescription_lbl
            // 
            this.incidentDescription_lbl.AutoSize = true;
            this.incidentDescription_lbl.Location = new System.Drawing.Point(880, 417);
            this.incidentDescription_lbl.Name = "incidentDescription_lbl";
            this.incidentDescription_lbl.Size = new System.Drawing.Size(83, 17);
            this.incidentDescription_lbl.TabIndex = 21;
            this.incidentDescription_lbl.Text = "Description:";
            // 
            // incidentDelete_btn
            // 
            this.incidentDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.incidentDelete_btn.Location = new System.Drawing.Point(880, 656);
            this.incidentDelete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentDelete_btn.Name = "incidentDelete_btn";
            this.incidentDelete_btn.Size = new System.Drawing.Size(209, 53);
            this.incidentDelete_btn.TabIndex = 22;
            this.incidentDelete_btn.Text = "DELETE INCIDENT";
            this.incidentDelete_btn.UseVisualStyleBackColor = false;
            this.incidentDelete_btn.Click += new System.EventHandler(this.incidentDelete_btn_Click);
            // 
            // incidentUpdate_btn
            // 
            this.incidentUpdate_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentUpdate_btn.Location = new System.Drawing.Point(1097, 657);
            this.incidentUpdate_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentUpdate_btn.Name = "incidentUpdate_btn";
            this.incidentUpdate_btn.Size = new System.Drawing.Size(201, 53);
            this.incidentUpdate_btn.TabIndex = 23;
            this.incidentUpdate_btn.Text = "UPDATE INCIDENT";
            this.incidentUpdate_btn.UseVisualStyleBackColor = false;
            this.incidentUpdate_btn.Click += new System.EventHandler(this.incidentUpdate_btn_Click);
            // 
            // incidentStatus_cbx
            // 
            this.incidentStatus_cbx.FormattingEnabled = true;
            this.incidentStatus_cbx.Location = new System.Drawing.Point(1059, 228);
            this.incidentStatus_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incidentStatus_cbx.Name = "incidentStatus_cbx";
            this.incidentStatus_cbx.Size = new System.Drawing.Size(239, 24);
            this.incidentStatus_cbx.TabIndex = 24;
            // 
            // incidentPriority_cbx
            // 
            this.incidentPriority_cbx.FormattingEnabled = true;
            this.incidentPriority_cbx.Location = new System.Drawing.Point(1059, 261);
            this.incidentPriority_cbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incidentPriority_cbx.Name = "incidentPriority_cbx";
            this.incidentPriority_cbx.Size = new System.Drawing.Size(239, 24);
            this.incidentPriority_cbx.TabIndex = 25;
            // 
            // incidentMain_tbx
            // 
            this.incidentMain_tbx.Enabled = false;
            this.incidentMain_tbx.Location = new System.Drawing.Point(1059, 341);
            this.incidentMain_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incidentMain_tbx.Name = "incidentMain_tbx";
            this.incidentMain_tbx.Size = new System.Drawing.Size(239, 22);
            this.incidentMain_tbx.TabIndex = 26;
            // 
            // incidentSub_tbx
            // 
            this.incidentSub_tbx.Enabled = false;
            this.incidentSub_tbx.Location = new System.Drawing.Point(880, 370);
            this.incidentSub_tbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incidentSub_tbx.Name = "incidentSub_tbx";
            this.incidentSub_tbx.Size = new System.Drawing.Size(417, 22);
            this.incidentSub_tbx.TabIndex = 27;
            // 
            // incidentCategory_lbl
            // 
            this.incidentCategory_lbl.AutoSize = true;
            this.incidentCategory_lbl.Location = new System.Drawing.Point(876, 345);
            this.incidentCategory_lbl.Name = "incidentCategory_lbl";
            this.incidentCategory_lbl.Size = new System.Drawing.Size(69, 17);
            this.incidentCategory_lbl.TabIndex = 28;
            this.incidentCategory_lbl.Text = "Category:";
            // 
            // incidentStatus_lbl
            // 
            this.incidentStatus_lbl.AutoSize = true;
            this.incidentStatus_lbl.Location = new System.Drawing.Point(876, 238);
            this.incidentStatus_lbl.Name = "incidentStatus_lbl";
            this.incidentStatus_lbl.Size = new System.Drawing.Size(48, 17);
            this.incidentStatus_lbl.TabIndex = 30;
            this.incidentStatus_lbl.Text = "Satus:";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Location = new System.Drawing.Point(876, 271);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(56, 17);
            this.Priority_lbl.TabIndex = 32;
            this.Priority_lbl.Text = "Priority:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(859, 181);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(468, 539);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket Information";
            // 
            // resolvedIncident_ckbx
            // 
            this.resolvedIncident_ckbx.AutoSize = true;
            this.resolvedIncident_ckbx.Location = new System.Drawing.Point(37, 185);
            this.resolvedIncident_ckbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resolvedIncident_ckbx.Name = "resolvedIncident_ckbx";
            this.resolvedIncident_ckbx.Size = new System.Drawing.Size(89, 21);
            this.resolvedIncident_ckbx.TabIndex = 34;
            this.resolvedIncident_ckbx.Text = "Resolved";
            this.resolvedIncident_ckbx.UseVisualStyleBackColor = true;
            this.resolvedIncident_ckbx.CheckedChanged += new System.EventHandler(this.urgentIncident_ckbx_CheckedChanged);
            // 
            // UnresolvedIncident_ckbx
            // 
            this.UnresolvedIncident_ckbx.AutoSize = true;
            this.UnresolvedIncident_ckbx.Location = new System.Drawing.Point(143, 185);
            this.UnresolvedIncident_ckbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnresolvedIncident_ckbx.Name = "UnresolvedIncident_ckbx";
            this.UnresolvedIncident_ckbx.Size = new System.Drawing.Size(102, 21);
            this.UnresolvedIncident_ckbx.TabIndex = 35;
            this.UnresolvedIncident_ckbx.Text = "Unresolved";
            this.UnresolvedIncident_ckbx.UseVisualStyleBackColor = true;
            this.UnresolvedIncident_ckbx.CheckedChanged += new System.EventHandler(this.urgentIncident_ckbx_CheckedChanged);
            // 
            // InProcessIncident_ckbx
            // 
            this.InProcessIncident_ckbx.AutoSize = true;
            this.InProcessIncident_ckbx.Location = new System.Drawing.Point(248, 185);
            this.InProcessIncident_ckbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InProcessIncident_ckbx.Name = "InProcessIncident_ckbx";
            this.InProcessIncident_ckbx.Size = new System.Drawing.Size(96, 21);
            this.InProcessIncident_ckbx.TabIndex = 36;
            this.InProcessIncident_ckbx.Text = "In Process";
            this.InProcessIncident_ckbx.UseVisualStyleBackColor = true;
            this.InProcessIncident_ckbx.CheckedChanged += new System.EventHandler(this.urgentIncident_ckbx_CheckedChanged);
            // 
            // urgentIncident_ckbx
            // 
            this.urgentIncident_ckbx.AutoSize = true;
            this.urgentIncident_ckbx.Location = new System.Drawing.Point(418, 185);
            this.urgentIncident_ckbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.urgentIncident_ckbx.Name = "urgentIncident_ckbx";
            this.urgentIncident_ckbx.Size = new System.Drawing.Size(73, 21);
            this.urgentIncident_ckbx.TabIndex = 37;
            this.urgentIncident_ckbx.Text = "Urgent";
            this.urgentIncident_ckbx.UseVisualStyleBackColor = true;
            this.urgentIncident_ckbx.CheckedChanged += new System.EventHandler(this.urgentIncident_ckbx_CheckedChanged);
            // 
            // pastDeadline_ckbx
            // 
            this.pastDeadline_ckbx.AutoSize = true;
            this.pastDeadline_ckbx.Location = new System.Drawing.Point(418, 160);
            this.pastDeadline_ckbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pastDeadline_ckbx.Name = "pastDeadline_ckbx";
            this.pastDeadline_ckbx.Size = new System.Drawing.Size(118, 21);
            this.pastDeadline_ckbx.TabIndex = 38;
            this.pastDeadline_ckbx.Text = "Past Deadline";
            this.pastDeadline_ckbx.UseVisualStyleBackColor = true;
            this.pastDeadline_ckbx.CheckedChanged += new System.EventHandler(this.pastDeadline_ckbx_CheckedChanged);
            // 
            // IncidentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 735);
            this.Controls.Add(this.pastDeadline_ckbx);
            this.Controls.Add(this.urgentIncident_ckbx);
            this.Controls.Add(this.InProcessIncident_ckbx);
            this.Controls.Add(this.UnresolvedIncident_ckbx);
            this.Controls.Add(this.resolvedIncident_ckbx);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IncidentManagment";
            this.Text = "IncidentManagment";
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
            this.Controls.SetChildIndex(this.resolvedIncident_ckbx, 0);
            this.Controls.SetChildIndex(this.UnresolvedIncident_ckbx, 0);
            this.Controls.SetChildIndex(this.InProcessIncident_ckbx, 0);
            this.Controls.SetChildIndex(this.urgentIncident_ckbx, 0);
            this.Controls.SetChildIndex(this.pastDeadline_ckbx, 0);
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
    }
}