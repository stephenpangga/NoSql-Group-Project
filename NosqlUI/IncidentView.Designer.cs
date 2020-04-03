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
            this.incident_lstvw.HideSelection = false;
            this.incident_lstvw.Location = new System.Drawing.Point(27, 199);
            this.incident_lstvw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.incident_lstvw.Name = "incident_lstvw";
            this.incident_lstvw.Size = new System.Drawing.Size(809, 406);
            this.incident_lstvw.TabIndex = 3;
            this.incident_lstvw.UseCompatibleStateImageBehavior = false;
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
            // IncidentManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 634);
            this.Controls.Add(this.incidentCreate_btn);
            this.Controls.Add(this.incidentFilter_lbl);
            this.Controls.Add(this.incidentFilter_txtbx);
            this.Controls.Add(this.incidentViewTitle_lbl);
            this.Controls.Add(this.incident_lstvw);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IncidentManagment";
            this.Text = "IncidentManagment";
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            this.Controls.SetChildIndex(this.incident_lstvw, 0);
            this.Controls.SetChildIndex(this.incidentViewTitle_lbl, 0);
            this.Controls.SetChildIndex(this.incidentFilter_txtbx, 0);
            this.Controls.SetChildIndex(this.incidentFilter_lbl, 0);
            this.Controls.SetChildIndex(this.incidentCreate_btn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView incident_lstvw;
        private System.Windows.Forms.Label incidentViewTitle_lbl;
        private System.Windows.Forms.TextBox incidentFilter_txtbx;
        private System.Windows.Forms.Label incidentFilter_lbl;
        private System.Windows.Forms.Button incidentCreate_btn;
    }
}