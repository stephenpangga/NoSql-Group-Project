namespace NosqlUI
{
    partial class CustomerChangeInfoForm
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
            this.ChngeEmaillbl = new System.Windows.Forms.Label();
            this.ChngeEmailtxtbx = new System.Windows.Forms.TextBox();
            this.ChngeEmailBtn = new System.Windows.Forms.Button();
            this.ChangePswdlbl = new System.Windows.Forms.Label();
            this.ChngePswdtxtbx = new System.Windows.Forms.TextBox();
            this.ChngePswdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChngeEmaillbl
            // 
            this.ChngeEmaillbl.AutoSize = true;
            this.ChngeEmaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChngeEmaillbl.Location = new System.Drawing.Point(44, 92);
            this.ChngeEmaillbl.Name = "ChngeEmaillbl";
            this.ChngeEmaillbl.Size = new System.Drawing.Size(108, 25);
            this.ChngeEmaillbl.TabIndex = 1;
            this.ChngeEmaillbl.Text = "New email:";
            // 
            // ChngeEmailtxtbx
            // 
            this.ChngeEmailtxtbx.Location = new System.Drawing.Point(205, 96);
            this.ChngeEmailtxtbx.Name = "ChngeEmailtxtbx";
            this.ChngeEmailtxtbx.Size = new System.Drawing.Size(181, 22);
            this.ChngeEmailtxtbx.TabIndex = 3;
            // 
            // ChngeEmailBtn
            // 
            this.ChngeEmailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChngeEmailBtn.Location = new System.Drawing.Point(472, 85);
            this.ChngeEmailBtn.Name = "ChngeEmailBtn";
            this.ChngeEmailBtn.Size = new System.Drawing.Size(156, 32);
            this.ChngeEmailBtn.TabIndex = 4;
            this.ChngeEmailBtn.Text = "Change email";
            this.ChngeEmailBtn.UseVisualStyleBackColor = true;
            this.ChngeEmailBtn.Click += new System.EventHandler(this.ChngeEmailBtn_Click);
            // 
            // ChangePswdlbl
            // 
            this.ChangePswdlbl.AutoSize = true;
            this.ChangePswdlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePswdlbl.Location = new System.Drawing.Point(44, 266);
            this.ChangePswdlbl.Name = "ChangePswdlbl";
            this.ChangePswdlbl.Size = new System.Drawing.Size(146, 25);
            this.ChangePswdlbl.TabIndex = 6;
            this.ChangePswdlbl.Text = "New password:";
            // 
            // ChngePswdtxtbx
            // 
            this.ChngePswdtxtbx.Location = new System.Drawing.Point(205, 270);
            this.ChngePswdtxtbx.Name = "ChngePswdtxtbx";
            this.ChngePswdtxtbx.Size = new System.Drawing.Size(181, 22);
            this.ChngePswdtxtbx.TabIndex = 7;
            // 
            // ChngePswdBtn
            // 
            this.ChngePswdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChngePswdBtn.Location = new System.Drawing.Point(472, 259);
            this.ChngePswdBtn.Name = "ChngePswdBtn";
            this.ChngePswdBtn.Size = new System.Drawing.Size(156, 32);
            this.ChngePswdBtn.TabIndex = 8;
            this.ChngePswdBtn.Text = "Change password";
            this.ChngePswdBtn.UseVisualStyleBackColor = true;
            this.ChngePswdBtn.Click += new System.EventHandler(this.ChngePswdBtn_Click);
            // 
            // CustomerChangeInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChngePswdBtn);
            this.Controls.Add(this.ChngePswdtxtbx);
            this.Controls.Add(this.ChangePswdlbl);
            this.Controls.Add(this.ChngeEmailBtn);
            this.Controls.Add(this.ChngeEmailtxtbx);
            this.Controls.Add(this.ChngeEmaillbl);
            this.Name = "CustomerChangeInfoForm";
            this.Text = "CustomerChangeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ChngeEmaillbl;
        private System.Windows.Forms.TextBox ChngeEmailtxtbx;
        private System.Windows.Forms.Button ChngeEmailBtn;
        private System.Windows.Forms.Label ChangePswdlbl;
        private System.Windows.Forms.TextBox ChngePswdtxtbx;
        private System.Windows.Forms.Button ChngePswdBtn;
    }
}