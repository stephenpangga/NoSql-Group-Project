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
            this.incidentFilter_txtbx = new System.Windows.Forms.TextBox();
            this.incidentFilter_lbl = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(30, 28);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(276, 28);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(521, 28);
            // 
            // incident_lstvw
            // 
            this.incident_lstvw.FullRowSelect = true;
            this.incident_lstvw.HideSelection = false;
            this.incident_lstvw.Location = new System.Drawing.Point(27, 199);
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
            this.incidentViewTitle_lbl.Location = new System.Drawing.Point(27, 94);
            this.incidentViewTitle_lbl.Name = "incidentViewTitle_lbl";
            this.incidentViewTitle_lbl.Size = new System.Drawing.Size(230, 33);
            this.incidentViewTitle_lbl.TabIndex = 4;
            this.incidentViewTitle_lbl.Text = "Overview tickets";
            // 
            // incidentFilter_txtbx
            // 
            this.incidentFilter_txtbx.Location = new System.Drawing.Point(27, 154);
            this.incidentFilter_txtbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incidentFilter_txtbx.Name = "incidentFilter_txtbx";
            this.incidentFilter_txtbx.Size = new System.Drawing.Size(255, 22);
            this.incidentFilter_txtbx.TabIndex = 5;
            // 
            // incidentFilter_lbl
            // 
            this.incidentFilter_lbl.AutoSize = true;
            this.incidentFilter_lbl.Location = new System.Drawing.Point(27, 130);
            this.incidentFilter_lbl.Name = "incidentFilter_lbl";
            this.incidentFilter_lbl.Size = new System.Drawing.Size(95, 17);
            this.incidentFilter_lbl.TabIndex = 6;
            this.incidentFilter_lbl.Text = "filter by email:";
            // 
            // incidentCreate_btn
            // 
            this.incidentCreate_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentCreate_btn.Location = new System.Drawing.Point(619, 130);
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
            this.incidentDescription_rtbx.Location = new System.Drawing.Point(878, 417);
            this.incidentDescription_rtbx.Name = "incidentDescription_rtbx";
            this.incidentDescription_rtbx.Size = new System.Drawing.Size(417, 188);
            this.incidentDescription_rtbx.TabIndex = 20;
            this.incidentDescription_rtbx.Text = "";
            // 
            // incidentDescription_lbl
            // 
            this.incidentDescription_lbl.AutoSize = true;
            this.incidentDescription_lbl.Location = new System.Drawing.Point(878, 394);
            this.incidentDescription_lbl.Name = "incidentDescription_lbl";
            this.incidentDescription_lbl.Size = new System.Drawing.Size(83, 17);
            this.incidentDescription_lbl.TabIndex = 21;
            this.incidentDescription_lbl.Text = "Description:";
            // 
            // incidentDelete_btn
            // 
            this.incidentDelete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.incidentDelete_btn.Location = new System.Drawing.Point(868, 626);
            this.incidentDelete_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentDelete_btn.Name = "incidentDelete_btn";
            this.incidentDelete_btn.Size = new System.Drawing.Size(219, 53);
            this.incidentDelete_btn.TabIndex = 22;
            this.incidentDelete_btn.Text = "DELETE INCIDENT";
            this.incidentDelete_btn.UseVisualStyleBackColor = false;
            this.incidentDelete_btn.Click += new System.EventHandler(this.incidentDelete_btn_Click);
            // 
            // incidentUpdate_btn
            // 
            this.incidentUpdate_btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.incidentUpdate_btn.Location = new System.Drawing.Point(1095, 626);
            this.incidentUpdate_btn.Margin = new System.Windows.Forms.Padding(4);
            this.incidentUpdate_btn.Name = "incidentUpdate_btn";
            this.incidentUpdate_btn.Size = new System.Drawing.Size(219, 53);
            this.incidentUpdate_btn.TabIndex = 23;
            this.incidentUpdate_btn.Text = "UPDATE INCIDENT";
            this.incidentUpdate_btn.UseVisualStyleBackColor = false;
            this.incidentUpdate_btn.Click += new System.EventHandler(this.incidentUpdate_btn_Click);
            // 
            // incidentStatus_cbx
            // 
            this.incidentStatus_cbx.FormattingEnabled = true;
            this.incidentStatus_cbx.Location = new System.Drawing.Point(1056, 199);
            this.incidentStatus_cbx.Name = "incidentStatus_cbx";
            this.incidentStatus_cbx.Size = new System.Drawing.Size(239, 24);
            this.incidentStatus_cbx.TabIndex = 24;
            // 
            // incidentPriority_cbx
            // 
            this.incidentPriority_cbx.FormattingEnabled = true;
            this.incidentPriority_cbx.Location = new System.Drawing.Point(1056, 229);
            this.incidentPriority_cbx.Name = "incidentPriority_cbx";
            this.incidentPriority_cbx.Size = new System.Drawing.Size(239, 24);
            this.incidentPriority_cbx.TabIndex = 25;
            // 
            // incidentMain_tbx
            // 
            this.incidentMain_tbx.Enabled = false;
            this.incidentMain_tbx.Location = new System.Drawing.Point(1056, 311);
            this.incidentMain_tbx.Name = "incidentMain_tbx";
            this.incidentMain_tbx.Size = new System.Drawing.Size(239, 22);
            this.incidentMain_tbx.TabIndex = 26;
            // 
            // incidentSub_tbx
            // 
            this.incidentSub_tbx.Enabled = false;
            this.incidentSub_tbx.Location = new System.Drawing.Point(881, 339);
            this.incidentSub_tbx.Name = "incidentSub_tbx";
            this.incidentSub_tbx.Size = new System.Drawing.Size(413, 22);
            this.incidentSub_tbx.TabIndex = 27;
            // 
            // incidentCategory_lbl
            // 
            this.incidentCategory_lbl.AutoSize = true;
            this.incidentCategory_lbl.Location = new System.Drawing.Point(878, 314);
            this.incidentCategory_lbl.Name = "incidentCategory_lbl";
            this.incidentCategory_lbl.Size = new System.Drawing.Size(69, 17);
            this.incidentCategory_lbl.TabIndex = 28;
            this.incidentCategory_lbl.Text = "Category:";
            // 
            // incidentStatus_lbl
            // 
            this.incidentStatus_lbl.AutoSize = true;
            this.incidentStatus_lbl.Location = new System.Drawing.Point(878, 202);
            this.incidentStatus_lbl.Name = "incidentStatus_lbl";
            this.incidentStatus_lbl.Size = new System.Drawing.Size(48, 17);
            this.incidentStatus_lbl.TabIndex = 30;
            this.incidentStatus_lbl.Text = "Satus:";
            // 
            // Priority_lbl
            // 
            this.Priority_lbl.AutoSize = true;
            this.Priority_lbl.Location = new System.Drawing.Point(875, 232);
            this.Priority_lbl.Name = "Priority_lbl";
            this.Priority_lbl.Size = new System.Drawing.Size(56, 17);
            this.Priority_lbl.TabIndex = 32;
            this.Priority_lbl.Text = "Priority:";
            // 
            // IncidentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 703);
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
            this.Controls.Add(this.incidentFilter_lbl);
            this.Controls.Add(this.incidentFilter_txtbx);
            this.Controls.Add(this.incidentViewTitle_lbl);
            this.Controls.Add(this.incident_lstvw);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IncidentManagment";
            this.Text = "IncidentManagment";
            this.Controls.SetChildIndex(this.linegrBox, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            this.Controls.SetChildIndex(this.incident_lstvw, 0);
            this.Controls.SetChildIndex(this.incidentViewTitle_lbl, 0);
            this.Controls.SetChildIndex(this.incidentFilter_txtbx, 0);
            this.Controls.SetChildIndex(this.incidentFilter_lbl, 0);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView incident_lstvw;
        private System.Windows.Forms.Label incidentViewTitle_lbl;
        private System.Windows.Forms.TextBox incidentFilter_txtbx;
        private System.Windows.Forms.Label incidentFilter_lbl;
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
    }
}