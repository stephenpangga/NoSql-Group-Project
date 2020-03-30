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
    public partial class CustomerManagement : Form
    {
        Customers_Logic customers_Logic = new Customers_Logic();
        public CustomerManagement()
        {
            InitializeComponent();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            List<Employees> employees = new List<Employees>();
            employees = customers_Logic.getAllEmployees("user");

            showCustomers.Columns.Add("ID", 30);
            showCustomers.Columns.Add("E-Mail", 160);
            showCustomers.Columns.Add("Password", 140);
            showCustomers.Columns.Add("First Name", 140);
            showCustomers.Columns.Add("Last Name", 140);
            showCustomers.Columns.Add("Role", 140);

            foreach (Employees employee in employees)
            {
                var item = new string[6] { employee.userID.ToString(), employee.email.ToString(), employee.password.ToString(), employee.firstName.ToString(), 
                    employee.lastName.ToString(), employee.role.ToString() };

                showCustomers.Items.Add(new ListViewItem(item));
            }
        }
    }
}
