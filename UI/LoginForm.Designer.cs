namespace UI
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
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_dashboard
            // 
            this.Btn_dashboard.Click += new System.EventHandler(this.Btn_dashboard_Click);
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(177, 245);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(381, 37);
            this.Btn_login.TabIndex = 3;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(177, 314);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(381, 37);
            this.Btn_reset.TabIndex = 4;
            this.Btn_reset.Text = "Password Reset";
            this.Btn_reset.UseVisualStyleBackColor = true;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(289, 157);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(269, 20);
            this.txt_username.TabIndex = 5;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(289, 198);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(269, 20);
            this.txt_password.TabIndex = 6;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(174, 157);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(55, 13);
            this.lbl_user.TabIndex = 7;
            this.lbl_user.Text = "Username";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(174, 198);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(53, 13);
            this.lbl_pass.TabIndex = 8;
            this.lbl_pass.Text = "Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Controls.SetChildIndex(this.Btn_dashboard, 0);
            this.Controls.SetChildIndex(this.Btn_incident, 0);
            this.Controls.SetChildIndex(this.Btn_user, 0);
            this.Controls.SetChildIndex(this.Btn_login, 0);
            this.Controls.SetChildIndex(this.Btn_reset, 0);
            this.Controls.SetChildIndex(this.txt_username, 0);
            this.Controls.SetChildIndex(this.txt_password, 0);
            this.Controls.SetChildIndex(this.lbl_user, 0);
            this.Controls.SetChildIndex(this.lbl_pass, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
    }
}