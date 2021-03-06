﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NosqlLogic;
using NosqlModel;

namespace NosqlUI
{
    public partial class AddCustomer : Form
    {
        Customers_Logic customers_Logic = new Customers_Logic();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //We'll check if the boxes are all filled. Else we'll change the label to a red warning text.
            if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(mailBox.Text) || String.IsNullOrEmpty(roleBox.Text))
            { warningLabel.Text = "Pleas fill in all boxes!"; warningLabel.ForeColor = Color.Red; }
            //Send all the data through to the database and end with a pop-up.
            else
            {
                customers_Logic.createUser(firstNameBox.Text, lastNameBox.Text, mailBox.Text, roleBox.Text);
                CustomerManagementSuccess PopUp = new CustomerManagementSuccess(); 
                PopUp.Show();
                this.Close();
            }
            
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
