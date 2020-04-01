using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using NosqlLogic;
using NosqlModel;

namespace NosqlUI
{
    public partial class ForgotPassForm : Form
    {
        Customers_Logic customers_Logic = new Customers_Logic();
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checks if the textbox is empty or not,if filled then goes ahead
            if (!string.IsNullOrEmpty(frgtemailtxtbox.Text))
            {
                //using regex to check if email is valid

                Regex rEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (!rEmail.IsMatch(frgtemailtxtbox.Text.Trim()))
                {
                    MessageBox.Show("Email must be a valid email!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //use the name from login form for changing stuff
                    string email = frgtemailtxtbox.Text;
                    customers_Logic.SendEmail(email);
                    MessageBox.Show("An email was sent to the provided email address.Also, check your spam folder!", "Successfull.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frgtemailtxtbox.Clear();
                }

            }
            else
            {
                MessageBox.Show("Email field must not be empty!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
