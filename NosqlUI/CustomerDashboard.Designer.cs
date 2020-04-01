namespace NosqlUI
{
    partial class CustomerDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_EmployeeName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_EmployeeName
            // 
            this.lbl_EmployeeName.AutoSize = true;
            this.lbl_EmployeeName.Location = new System.Drawing.Point(63, 15);
            this.lbl_EmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_EmployeeName.Name = "lbl_EmployeeName";
            this.lbl_EmployeeName.Size = new System.Drawing.Size(82, 13);
            this.lbl_EmployeeName.TabIndex = 1;
            this.lbl_EmployeeName.Text = "Employee name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataListView
            // 
            this.dataListView.HideSelection = false;
            this.dataListView.Location = new System.Drawing.Point(11, 52);
            this.dataListView.Margin = new System.Windows.Forms.Padding(2);
            this.dataListView.Name = "dataListView";
            this.dataListView.Size = new System.Drawing.Size(732, 309);
            this.dataListView.TabIndex = 3;
            this.dataListView.UseCompatibleStateImageBehavior = false;
            this.dataListView.View = System.Windows.Forms.View.Details;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 428);
            this.Controls.Add(this.dataListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_EmployeeName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerDashboard";
            this.Text = "EmployeeDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_EmployeeName;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.ListView dataListView;
    }
}