﻿namespace NosqlUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_IncidentM = new System.Windows.Forms.Button();
            this.btn_UserM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(129, 60);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Dashboard.Size = new System.Drawing.Size(178, 33);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "DashBoard";
            this.btn_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_IncidentM
            // 
            this.btn_IncidentM.Location = new System.Drawing.Point(313, 60);
            this.btn_IncidentM.Name = "btn_IncidentM";
            this.btn_IncidentM.Size = new System.Drawing.Size(178, 33);
            this.btn_IncidentM.TabIndex = 1;
            this.btn_IncidentM.Text = "Incident Management";
            this.btn_IncidentM.UseVisualStyleBackColor = true;
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(497, 60);
            this.btn_UserM.Name = "btn_UserM";
            this.btn_UserM.Size = new System.Drawing.Size(178, 33);
            this.btn_UserM.TabIndex = 2;
            this.btn_UserM.Text = "User Management";
            this.btn_UserM.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_UserM);
            this.Controls.Add(this.btn_IncidentM);
            this.Controls.Add(this.btn_Dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btn_Dashboard;
        protected System.Windows.Forms.Button btn_IncidentM;
        protected System.Windows.Forms.Button btn_UserM;
    }
}

