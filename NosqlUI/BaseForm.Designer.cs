namespace NosqlUI
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
            this.linegrBox = new System.Windows.Forms.GroupBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.Location = new System.Drawing.Point(133, 56);
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
            this.btn_IncidentM.Location = new System.Drawing.Point(317, 56);
            this.btn_IncidentM.Name = "btn_IncidentM";
            this.btn_IncidentM.Size = new System.Drawing.Size(178, 33);
            this.btn_IncidentM.TabIndex = 1;
            this.btn_IncidentM.Text = "Incident Management";
            this.btn_IncidentM.UseVisualStyleBackColor = true;
            this.btn_IncidentM.Click += new System.EventHandler(this.btn_IncidentM_Click);
            // 
            // btn_UserM
            // 
            this.btn_UserM.Location = new System.Drawing.Point(501, 56);
            this.btn_UserM.Name = "btn_UserM";
            this.btn_UserM.Size = new System.Drawing.Size(178, 33);
            this.btn_UserM.TabIndex = 2;
            this.btn_UserM.Text = "User Management";
            this.btn_UserM.UseVisualStyleBackColor = true;
            this.btn_UserM.Click += new System.EventHandler(this.btn_UserM_Click);
            // 
            // linegrBox
            // 
            this.linegrBox.BackColor = System.Drawing.Color.Transparent;
            this.linegrBox.Location = new System.Drawing.Point(12, 95);
            this.linegrBox.Name = "linegrBox";
            this.linegrBox.Size = new System.Drawing.Size(776, 10);
            this.linegrBox.TabIndex = 3;
            this.linegrBox.TabStop = false;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(714, 56);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(74, 33);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.linegrBox);
            this.Controls.Add(this.btn_UserM);
            this.Controls.Add(this.btn_IncidentM);
            this.Controls.Add(this.btn_Dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btn_Dashboard;
        protected System.Windows.Forms.Button btn_IncidentM;
        protected System.Windows.Forms.Button btn_UserM;
        protected System.Windows.Forms.GroupBox linegrBox;
        protected System.Windows.Forms.Button btn_logout;
    }
}

