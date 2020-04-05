using System;
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
        //This will be filled in EditCustomer and used globally in the different methods.
        int usedID = 0;
        Customers_Logic customers_Logic = new Customers_Logic();
        List<User> employees = new List<User>();

        public EditCustomer(int id)
        {
            //This is basically feedback to show which user you're working with. In hinesight I could have probably passed on first and last name from the previous form.
            InitializeComponent();
            usedID = id;
            string editThisEmployer = "";
            employees = customers_Logic.getAllEmployees("Users");

            foreach (User employee in employees)
            {
                if (employee.userId == id) { editThisEmployer = "ID: " + employee.userId.ToString() + " || " + employee.FirstName + " " + employee.LastName; }
            }
            userEditLabel.Text = editThisEmployer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            //We have to check if the boxes are filled or not. Once this is the case we send the data through to the database and close the form with a pop-up.
            if (String.IsNullOrEmpty(txtColumn.Text) || String.IsNullOrEmpty(textValue.Text))
            { userEditLabel.Text = "Please fill in all boxes"; userEditLabel.ForeColor = Color.Red; }
            else
            {
                customers_Logic.updateUser(usedID, textValue.Text, txtColumn.Text);
                CustomerManagementSuccess PopUp = new CustomerManagementSuccess();
                PopUp.Show();
                this.Close();
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
            //We send the id to the changePassword method, show a pop-up and close the form.
            customers_Logic.changePassword(usedID);
            CustomerManagementSuccess PopUp = new CustomerManagementSuccess();
            PopUp.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Here we use the variable role, which will be filled in the loop later.
            string role = "";
            employees = customers_Logic.getAllEmployees("Users");

            //First we've got to check which role the employee already has.
            foreach (User employee in employees)
            {
                //We find the user based on the Id that was passed through
                if (usedID == employee.userId)
                {
                    //And we give them the other role from the one they already had.
                    if (employee.roles.ToString() == "Admin") { role = "Employee"; }
                    else if (employee.roles.ToString() == "Employee") { role = "Admin"; }
                }
            }
            //It's send through to the database, we show them a pop-up that their task has been done and we close the edit form.
            customers_Logic.updateUser(usedID, role, "role");
            CustomerManagementSuccess PopUp = new CustomerManagementSuccess();
            PopUp.Show();
            this.Close();
        }
    }
}
