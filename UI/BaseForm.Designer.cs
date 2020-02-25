namespace UI
{
    partial class BaseForm
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
            this.Btn_dashboard = new System.Windows.Forms.Button();
            this.Btn_incident = new System.Windows.Forms.Button();
            this.Btn_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_dashboard
            // 
            this.Btn_dashboard.Location = new System.Drawing.Point(179, 117);
            this.Btn_dashboard.Name = "Btn_dashboard";
            this.Btn_dashboard.Size = new System.Drawing.Size(163, 23);
            this.Btn_dashboard.TabIndex = 0;
            this.Btn_dashboard.Text = "Dashboard";
            this.Btn_dashboard.UseVisualStyleBackColor = true;
            this.Btn_dashboard.Click += new System.EventHandler(this.Btn_dashboard_Click);
            // 
            // Btn_incident
            // 
            this.Btn_incident.Location = new System.Drawing.Point(348, 117);
            this.Btn_incident.Name = "Btn_incident";
            this.Btn_incident.Size = new System.Drawing.Size(163, 23);
            this.Btn_incident.TabIndex = 1;
            this.Btn_incident.Text = "Incidents";
            this.Btn_incident.UseVisualStyleBackColor = true;
            this.Btn_incident.Click += new System.EventHandler(this.Btn_incident_Click);
            // 
            // Btn_user
            // 
            this.Btn_user.Location = new System.Drawing.Point(517, 117);
            this.Btn_user.Name = "Btn_user";
            this.Btn_user.Size = new System.Drawing.Size(163, 23);
            this.Btn_user.TabIndex = 2;
            this.Btn_user.Text = "Users";
            this.Btn_user.UseVisualStyleBackColor = true;
            this.Btn_user.Click += new System.EventHandler(this.Btn_user_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.Btn_user);
            this.Controls.Add(this.Btn_incident);
            this.Controls.Add(this.Btn_dashboard);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button Btn_dashboard;
        protected System.Windows.Forms.Button Btn_incident;
        protected System.Windows.Forms.Button Btn_user;
    }
}

