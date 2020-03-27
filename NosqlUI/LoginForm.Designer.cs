namespace NosqlUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_login = new System.Windows.Forms.Button();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.link_resetpass = new System.Windows.Forms.LinkLabel();
            this.sisalbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(256, 263);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(215, 36);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(256, 167);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(361, 20);
            this.txtbox_email.TabIndex = 4;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(256, 218);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(361, 20);
            this.txtbox_password.TabIndex = 5;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(180, 170);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(45, 18);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Email";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(180, 221);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(75, 18);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // link_resetpass
            // 
            this.link_resetpass.AutoSize = true;
            this.link_resetpass.Location = new System.Drawing.Point(525, 275);
            this.link_resetpass.Name = "link_resetpass";
            this.link_resetpass.Size = new System.Drawing.Size(92, 13);
            this.link_resetpass.TabIndex = 8;
            this.link_resetpass.TabStop = true;
            this.link_resetpass.Text = "Forget Password?";
            // 
            // sisalbl
            // 
            this.sisalbl.AutoSize = true;
            this.sisalbl.Location = new System.Drawing.Point(256, 367);
            this.sisalbl.Name = "sisalbl";
            this.sisalbl.Size = new System.Drawing.Size(35, 13);
            this.sisalbl.TabIndex = 9;
            this.sisalbl.Text = "label1";
            this.sisalbl.Click += new System.EventHandler(this.sisalbl_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sisalbl);
            this.Controls.Add(this.link_resetpass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.LinkLabel link_resetpass;
        private System.Windows.Forms.Label sisalbl;
    }
}