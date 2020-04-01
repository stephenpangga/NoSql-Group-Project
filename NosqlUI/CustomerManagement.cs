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
        List<Employees> employees = new List<Employees>();
        public CustomerManagement()
        {
            InitializeComponent();
            LoadEmployees();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadEmployees()
        {
            employees = customers_Logic.getAllEmployees("Users");

            showCustomers.View = View.Details;

            showCustomers.Columns.Add("userID", -2, HorizontalAlignment.Left);
            showCustomers.Columns.Add("E-mail", -2, HorizontalAlignment.Left);
            showCustomers.Columns.Add("Password", -2, HorizontalAlignment.Left);
            showCustomers.Columns.Add("FirstName", -2, HorizontalAlignment.Left);
            showCustomers.Columns.Add("LastName", -2, HorizontalAlignment.Left);
            showCustomers.Columns.Add("Role", -2, HorizontalAlignment.Left);

            foreach (Employees employee in employees)
            {
                var item = new string[6] { employee.userID.ToString(), employee.email, employee.password, employee.firstName, employee.lastName, employee.role.ToString() };

                showCustomers.Items.Add(new ListViewItem(item));
            }
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void addbuttom_Click(object sender, EventArgs e)
        {

        }
    }
}
