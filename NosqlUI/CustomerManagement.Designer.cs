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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.showCustomers = new System.Windows.Forms.ListView();
            this.userID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Role = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // addbuttom
            // 
            this.addbuttom.Location = new System.Drawing.Point(885, 79);
            this.addbuttom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbuttom.Name = "addbuttom";
            this.addbuttom.Size = new System.Drawing.Size(149, 44);
            this.addbuttom.TabIndex = 0;
            this.addbuttom.Text = "Add employee";
            this.addbuttom.UseVisualStyleBackColor = true;
            this.addbuttom.Click += new System.EventHandler(this.addbuttom_Click);
            // 
            // editbuttom
            // 
            this.editbuttom.Location = new System.Drawing.Point(885, 143);
            this.editbuttom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editbuttom.Name = "editbuttom";
            this.editbuttom.Size = new System.Drawing.Size(149, 44);
            this.editbuttom.TabIndex = 1;
            this.editbuttom.Text = "Edit employee";
            this.editbuttom.UseVisualStyleBackColor = true;
            this.editbuttom.Click += new System.EventHandler(this.editbuttom_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(885, 209);
            this.deletebutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(149, 44);
            this.deletebutton.TabIndex = 2;
            this.deletebutton.Text = "Delete employee";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // returnbutton
            // 
            this.returnbutton.Location = new System.Drawing.Point(59, 27);
            this.returnbutton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnbutton.Name = "returnbutton";
            this.returnbutton.Size = new System.Drawing.Size(212, 34);
            this.returnbutton.TabIndex = 3;
            this.returnbutton.Text = "Go Back";
            this.returnbutton.UseVisualStyleBackColor = true;
            this.returnbutton.Click += new System.EventHandler(this.returnbutton_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // showCustomers
            // 
            this.showCustomers.BackgroundImageTiled = true;
            this.showCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userID,
            this.Email,
            this.FirstName,
            this.LastName,
            this.Role});
            this.showCustomers.FullRowSelect = true;
            this.showCustomers.GridLines = true;
            this.showCustomers.HideSelection = false;
            this.showCustomers.Location = new System.Drawing.Point(59, 79);
            this.showCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCustomers.Name = "showCustomers";
            this.showCustomers.Size = new System.Drawing.Size(817, 447);
            this.showCustomers.TabIndex = 4;
            this.showCustomers.UseCompatibleStateImageBehavior = false;
            this.showCustomers.SelectedIndexChanged += new System.EventHandler(this.showCustomers_SelectedIndexChanged);
            // 
            // userID
            // 
            this.userID.Text = "User ID";
            this.userID.Width = -2;
            // 
            // Email
            // 
            this.Email.Text = "E-mail";
            this.Email.Width = -2;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = -2;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = -2;
            // 
            // Role
            // 
            this.Role.Text = "Role";
            this.Role.Width = -2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reload data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showCustomers);
            this.Controls.Add(this.returnbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbuttom);
            this.Controls.Add(this.addbuttom);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CustomerManagement";
            this.Text = "CustomerManagement";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerManagement_FormClosed);
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            this.Controls.SetChildIndex(this.addbuttom, 0);
            this.Controls.SetChildIndex(this.editbuttom, 0);
            this.Controls.SetChildIndex(this.deletebutton, 0);
            this.Controls.SetChildIndex(this.returnbutton, 0);
            this.Controls.SetChildIndex(this.showCustomers, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.btn_Dashboard, 0);
            this.Controls.SetChildIndex(this.btn_IncidentM, 0);
            this.Controls.SetChildIndex(this.btn_UserM, 0);
            this.Controls.SetChildIndex(this.linegrBox, 0);
            this.Controls.SetChildIndex(this.btn_logout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addbuttom;
        private System.Windows.Forms.Button editbuttom;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button returnbutton;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ListView showCustomers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader userID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Role;
    }
}