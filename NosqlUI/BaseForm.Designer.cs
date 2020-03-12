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
            this.btn_dash = new System.Windows.Forms.Button();
            this.btn_incident = new System.Windows.Forms.Button();
            this.btn_userM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_dash
            // 
            this.btn_dash.Location = new System.Drawing.Point(213, 63);
            this.btn_dash.Name = "btn_dash";
            this.btn_dash.Size = new System.Drawing.Size(127, 48);
            this.btn_dash.TabIndex = 0;
            this.btn_dash.Text = "Dashboard";
            this.btn_dash.UseVisualStyleBackColor = true;
            // 
            // btn_incident
            // 
            this.btn_incident.Location = new System.Drawing.Point(356, 63);
            this.btn_incident.Name = "btn_incident";
            this.btn_incident.Size = new System.Drawing.Size(127, 48);
            this.btn_incident.TabIndex = 1;
            this.btn_incident.Text = "Incident Management";
            this.btn_incident.UseVisualStyleBackColor = true;
            // 
            // btn_userM
            // 
            this.btn_userM.Location = new System.Drawing.Point(504, 63);
            this.btn_userM.Name = "btn_userM";
            this.btn_userM.Size = new System.Drawing.Size(127, 48);
            this.btn_userM.TabIndex = 2;
            this.btn_userM.Text = "User Management";
            this.btn_userM.UseVisualStyleBackColor = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_userM);
            this.Controls.Add(this.btn_incident);
            this.Controls.Add(this.btn_dash);
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btn_dash;
        protected System.Windows.Forms.Button btn_incident;
        protected System.Windows.Forms.Button btn_userM;
    }
}

