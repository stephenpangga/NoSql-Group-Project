namespace NosqlUI
{
    partial class ForgotPassForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.frgtemailtxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frgtemailtxtbox
            // 
            this.frgtemailtxtbox.Location = new System.Drawing.Point(158, 114);
            this.frgtemailtxtbox.Name = "frgtemailtxtbox";
            this.frgtemailtxtbox.Size = new System.Drawing.Size(279, 22);
            this.frgtemailtxtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your email here and you will be sent a new temporary password.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your email:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ForgotPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frgtemailtxtbox);
            this.Controls.Add(this.button1);
            this.Name = "ForgotPassForm";
            this.Text = "ForgotPassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox frgtemailtxtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}