using System;
using System.Collections;
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
        List<User> employees = new List<User>();
        public CustomerManagement()
        {
            InitializeComponent();
            showCustomers.View = View.Details;
            LoadEmployees();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadEmployees()
        {
            employees = customers_Logic.getAllEmployees();

            foreach (User employee in employees)
            {
                var item = new string[6] { employee.userId.ToString(), employee.Email, employee.Password, employee.FirstName, employee.LastName, employee.roles.ToString() };

                showCustomers.Items.Add(new ListViewItem(item));
            }
        }

        string getSelectedId() 
        {
            //Here we take the selected item from the listview and taking the first row, the id
            string item = showCustomers.SelectedItems[0].ToString();
            //I couldn't figure out why it took more data than just the ID stored in the row, so here I filter the id numbers out of strin item.
            string id = "";
            for (int i = 0; i < item.Length; i++)
            {
               if (Char.IsDigit(item[i]))
                   id += item[i];
            }
            return id;
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void addbuttom_Click(object sender, EventArgs e)
        {
            AddCustomer AddCustomer = new AddCustomer();
            AddCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCustomers.Items.Clear();
            LoadEmployees();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (showCustomers.SelectedItems.Count < 1) { CustomerManagementPopUp PopUp = new CustomerManagementPopUp(); PopUp.Show(); }
            else
            {
                //RemoveCustomer RemoveCustomer = new RemoveCustomer(getSelectedId());
                //RemoveCustomer.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editbuttom_Click(object sender, EventArgs e)
        {
            if (showCustomers.SelectedItems.Count < 1) { CustomerManagementPopUp PopUp = new CustomerManagementPopUp(); PopUp.Show(); }
            else
            {
                EditCustomer EditCustomer = new EditCustomer(getSelectedId());
                EditCustomer.Show();
            }
        }


    }
}
