namespace NosqlUI
{
    partial class EditCustomer
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
            this.userEditLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtColumn = new System.Windows.Forms.ComboBox();
            this.textValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userEditLabel
            // 
            this.userEditLabel.AutoSize = true;
            this.userEditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.userEditLabel.Location = new System.Drawing.Point(296, 78);
            this.userEditLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userEditLabel.Name = "userEditLabel";
            this.userEditLabel.Size = new System.Drawing.Size(0, 31);
            this.userEditLabel.TabIndex = 0;
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.editButton.Location = new System.Drawing.Point(481, 373);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(256, 92);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit data";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(124, 373);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(217, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Catagory:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(223, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "New value:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(823, 283);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 64);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset Password";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(823, 401);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 64);
            this.button3.TabIndex = 8;
            this.button3.Text = "Switch role";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtColumn
            // 
            this.txtColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtColumn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtColumn.FormattingEnabled = true;
            this.txtColumn.Items.AddRange(new object[] {
            "userId",
            "email",
            "firstName",
            "lastName"});
            this.txtColumn.Location = new System.Drawing.Point(481, 162);
            this.txtColumn.Margin = new System.Windows.Forms.Padding(4);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(201, 39);
            this.txtColumn.TabIndex = 10;
            // 
            // textValue
            // 
            this.textValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textValue.Location = new System.Drawing.Point(481, 249);
            this.textValue.Margin = new System.Windows.Forms.Padding(4);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(201, 38);
            this.textValue.TabIndex = 11;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.userEditLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userEditLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox txtColumn;
        private System.Windows.Forms.TextBox textValue;
    }
}