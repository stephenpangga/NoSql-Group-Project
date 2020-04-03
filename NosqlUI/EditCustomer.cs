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
    public partial class EditCustomer : Form
    {
        string usedID = "";
        Customers_Logic customers_Logic = new Customers_Logic();
        List<User> employees = new List<User>();

        public EditCustomer(string id)
        {
            InitializeComponent();
            usedID = id;
            string editThisEmployer = "";
            InitializeComponent();
            employees = customers_Logic.getAllEmployees("Users");

            foreach (User employee in employees)
            {
                if (employee.userId.ToString() == id) { editThisEmployer = "ID: " + employee.userId.ToString() + " || " + employee.FirstName + " " + employee.LastName; }
            }
            userEditLabel.Text = editThisEmployer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = textValue.Text;
            userEditLabel.Text = value;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtColumn.Text) || String.IsNullOrEmpty(textValue.Text))
            { userEditLabel.Text = "Fill in all boxes, please*"; userEditLabel.ForeColor = Color.Red; }
            else
            {
                //customers_Logic.createUser(firstNameBox.Text, lastNameBox.Text, mailBox.Text, roleBox.Text);
                //this.Close();
                userEditLabel.Text = "Success.";
            }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void value_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            customers_Logic.changePassword(usedID);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string role = "";
            employees = customers_Logic.getAllEmployees("Users");

            foreach (User employee in employees)
            {
                if (employee.roles.ToString() == "Admin") { role = "Employee"; }
                else if (employee.roles.ToString() == "Employee") { role = "Admin"; }
            }
            customers_Logic.updateUser(usedID, role, "role");
            this.Close();
        }
    }
}
