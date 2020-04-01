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
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(341, 324);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(287, 44);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txtbox_email
            // 
            this.txtbox_email.Location = new System.Drawing.Point(341, 206);
            this.txtbox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(480, 22);
            this.txtbox_email.TabIndex = 4;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(341, 268);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(480, 22);
            this.txtbox_password.TabIndex = 5;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(200, 208);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(57, 24);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "Email";
            this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(200, 271);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(92, 24);
            this.lbl_pass.TabIndex = 7;
            this.lbl_pass.Text = "Password";
            this.lbl_pass.Click += new System.EventHandler(this.lbl_pass_Click);
            // 
            // link_resetpass
            // 
            this.link_resetpass.AutoSize = true;
            this.link_resetpass.Location = new System.Drawing.Point(700, 338);
            this.link_resetpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.link_resetpass.Name = "link_resetpass";
            this.link_resetpass.Size = new System.Drawing.Size(122, 17);
            this.link_resetpass.TabIndex = 8;
            this.link_resetpass.TabStop = true;
            this.link_resetpass.Text = "Forget Password?";
            this.link_resetpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_resetpass_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.link_resetpass);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Controls.SetChildIndex(this.btn_login, 0);
            this.Controls.SetChildIndex(this.txtbox_email, 0);
            this.Controls.SetChildIndex(this.txtbox_password, 0);
            this.Controls.SetChildIndex(this.lbl_user, 0);
            this.Controls.SetChildIndex(this.lbl_pass, 0);
            this.Controls.SetChildIndex(this.link_resetpass, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
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
    }
}