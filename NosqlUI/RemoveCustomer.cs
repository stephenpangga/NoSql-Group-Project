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
    public partial class RemoveCustomer : Form
    {
        int usedID = 0;
        Customers_Logic customers_Logic = new Customers_Logic();

        public RemoveCustomer(int id)
        {
            usedID = id;
            string deleteThisEmployer = "";
            InitializeComponent();
            List<User> employees = new List<User>();
            employees = customers_Logic.getAllEmployees("Users");

            foreach (User employee in employees)
            {
                if (employee.userId == id) { deleteThisEmployer = "ID: " + employee.userId.ToString() + " || " + employee.FirstName + " " + employee.LastName;  }
            }
            userLabel.Text = deleteThisEmployer;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            customers_Logic.deleteUser(usedID, "userId", "Users");
            CustomerManagementSuccess PopUp = new CustomerManagementSuccess(); 
            PopUp.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
