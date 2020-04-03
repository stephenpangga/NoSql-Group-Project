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
        string usedID = "";
        Customers_Logic customers_Logic = new Customers_Logic();

        public EditCustomer(string id)
        {
            InitializeComponent();
            usedID = id;
            string editThisEmployer = "";
            InitializeComponent();
            List<User> employees = new List<User>();
            employees = customers_Logic.getAllEmployees("Users");

            foreach (User employee in employees)
            {
                if (employee.userId.ToString() == id) { editThisEmployer = "Edit user: ID: " + employee.userId.ToString() + " || " + employee.FirstName + " " + employee.LastName; }
            }
            userEditLabel.Text = editThisEmployer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(column.Text) || String.IsNullOrEmpty(value.Text))
            { userEditLabel.Text = "Fill in all boxes, please*"; userEditLabel.ForeColor = Color.Red; }
            else { customers_Logic.updateUser(usedID, value.Text, column.Text); this.Close(); }
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
