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
    public partial class CustomerChangeInfoForm : Form
    {
        Customers_Logic customers_Logic = new Customers_Logic();
        bool check;
        int usrId;
        public CustomerChangeInfoForm(int userId)
        {
            InitializeComponent();
            usrId = userId;
            // The password character is an asterisk.
            ChngePswdtxtbx.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            ChngePswdtxtbx.MaxLength = 22;
        }

        private void ChngeEmailBtn_Click(object sender, EventArgs e)
        {
            
            //checks if the textbox is empty or not,if filled then goes ahead
            if (!string.IsNullOrEmpty(ChngeEmailtxtbx.Text))
            {
                //using regex to check if email is valid

                Regex rEmail = new Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (!rEmail.IsMatch(ChngeEmailtxtbx.Text.Trim()))
                {
                    MessageBox.Show("Email must be a valid email!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //use the name from login form for changing stuff
                    string newEmail = ChngeEmailtxtbx.Text;
                    check = customers_Logic.ChangeCustomerInfo("Users", usrId, "userId", newEmail, "email");
                    if (check == true)
                    {
                        MessageBox.Show("Your email was successfully changed.", "Successfull.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChngeEmailtxtbx.Clear();
                    }
                    else
                    {
                        MessageBox.Show("An error occured");
                    }
                }

            }
            else
            {
                MessageBox.Show("Email field must not be empty!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //need to hash password
        private void ChngePswdBtn_Click(object sender, EventArgs e)
        {
            //checks if the textbox is empty or not,if filled then goes ahead
            if (!string.IsNullOrEmpty(ChngePswdtxtbx.Text))
            {
                string newPassword = ChngePswdtxtbx.Text;
                

                if(newPassword.Length > 7)
                {
                    check= customers_Logic.ChangeCustomerInfo("Users", usrId, "userId", newPassword, "password");
                    if(check == true)
                    {
                        MessageBox.Show("Your password was successfully changed.", "Successfull.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChngePswdtxtbx.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Your password should be more than 7 letters", "Password length error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Password field must not be empty!", "Unsuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerChangeInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void CustomerChangeInfoForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
