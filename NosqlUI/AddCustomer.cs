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
            if (String.IsNullOrEmpty(firstNameBox.Text) || String.IsNullOrEmpty(lastNameBox.Text) || String.IsNullOrEmpty(mailBox.Text) || String.IsNullOrEmpty(roleBox.Text))
            { warningLabel.Text = "Fill in all boxes, please*"; warningLabel.ForeColor = Color.Red; }
            else
            {
                customers_Logic.createUser(firstNameBox.Text, lastNameBox.Text, mailBox.Text, roleBox.Text);
                this.Close();
            }
            
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
