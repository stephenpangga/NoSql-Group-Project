namespace NosqlUI
{
    partial class CustomerManagement
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
            this.addbuttom = new System.Windows.Forms.Button();
            this.editbuttom = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.returnbutton = new System.Windows.Forms.Button();
            this.showCustomers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // addbuttom
            // 
            this.addbuttom.Location = new System.Drawing.Point(664, 64);
            this.addbuttom.Name = "addbuttom";
            this.addbuttom.Size = new System.Drawing.Size(112, 36);
            this.addbuttom.TabIndex = 0;
            this.addbuttom.Text = "Add employee";
            this.addbuttom.UseVisualStyleBackColor = true;
            // 
            // editbuttom
            // 
            this.editbuttom.Location = new System.Drawing.Point(664, 116);
            this.editbuttom.Name = "editbuttom";
            this.editbuttom.Size = new System.Drawing.Size(112, 36);
            this.editbuttom.TabIndex = 1;
            this.editbuttom.Text = "Edit employee";
            this.editbuttom.UseVisualStyleBackColor = true;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(664, 170);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(112, 36);
            this.deletebutton.TabIndex = 2;
            this.deletebutton.Text = "Delete employee";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(44, 22);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(159, 28);
            this.returnbutton.TabIndex = 3;
            this.returnbutton.Text = "Go Back";
            this.returnbutton.UseVisualStyleBackColor = true;
            // 
            // showCustomers
            // 
            this.showCustomers.HideSelection = false;
            this.showCustomers.Location = new System.Drawing.Point(44, 64);
            this.showCustomers.Name = "showCustomers";
            this.showCustomers.Size = new System.Drawing.Size(581, 352);
            this.showCustomers.TabIndex = 4;
            this.showCustomers.UseCompatibleStateImageBehavior = false;
            this.showCustomers.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showCustomers);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbuttom);
            this.Controls.Add(this.addbuttom);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbuttom;
        private System.Windows.Forms.Button editbuttom;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button returnbutton;
        private System.Windows.Forms.ListView showCustomers;
    }
}