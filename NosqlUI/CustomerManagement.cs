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
    public partial class CustomerManagement : BaseForm
    {
        Customers_Logic customers_Logic = new Customers_Logic();
        List<User> employees = new List<User>();
        public CustomerManagement(User currentUser)
        {
            this.currentUser = currentUser;
            InitializeComponent();
            hideButtons();
            showCustomers.View = View.Details;
            LoadEmployees();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadEmployees()
        {
            //Get the list of all users / employees
            employees = customers_Logic.getAllEmployees("Users");

            //Add each user with all their data to the listview (Besides password. Password would be easy to add to this list, though.)
            foreach (User employee in employees)
            {
                var item = new string[5] { employee.userId.ToString(), employee.Email, employee.FirstName, employee.LastName, employee.roles.ToString() };

                showCustomers.Items.Add(new ListViewItem(item));
            }
        }

        int getSelectedId() 
        {
            //Here we take the selected item from the listview and taking the first row, the id
            string item = showCustomers.SelectedItems[0].ToString();
            string id = "";
            //For some odd reason, it took a weird string, like databaseID { 106 }, or something like that so I'm filtering out the numbers and sending it back as an int.
            for (int i = 0; i < item.Length; i++)
            {
               if (Char.IsDigit(item[i]))
                   id += item[i];
            }
            return Int32.Parse(id);
        }

        private void CustomerManagement_Load(object sender, EventArgs e)
        {

        }

        private void addbuttom_Click(object sender, EventArgs e)
        {
            //Show the addusers form.
            AddCustomer AddCustomer = new AddCustomer();
            AddCustomer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clear all items in the list and reload them from the database.
            showCustomers.Items.Clear();
            LoadEmployees();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //See if a user was selected. If not, show a pop-up. Else show the customer delete form.
            if (showCustomers.SelectedItems.Count < 1) 
            { CustomerManagementPopUp PopUp = new CustomerManagementPopUp(); PopUp.Show(); }
            else
            {
                RemoveCustomer RemoveCustomer = new RemoveCustomer(getSelectedId());
                RemoveCustomer.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void editbuttom_Click(object sender, EventArgs e)
        {
            //See if a user was selected. If not, show a pop-up. Else show the customer edit form.
            if (showCustomers.SelectedItems.Count < 1) 
            { CustomerManagementPopUp PopUp = new CustomerManagementPopUp(); PopUp.Show(); }
            else
            {
                EditCustomer EditCustomer = new EditCustomer(getSelectedId());
                EditCustomer.Show();
            }
        }

        private void showCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void returnbutton_Click(object sender, EventArgs e)
        {
            DashBoardForm d = new DashBoardForm(currentUser);
            d.Show();
            this.Hide();
        }

        private void CustomerManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
