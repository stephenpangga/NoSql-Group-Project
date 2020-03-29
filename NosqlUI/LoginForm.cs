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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            //hide the base buttons
            //Users_Logic userlogic = new Users_Logic();
            //User u = userlogic.SearchUser("Users", "admin");
            //User u = userlogic.getByEmail("useratgmaisl.com");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashBoardForm dashboard = new DashBoardForm();

            //user info
            string email = txtbox_email.Text;
            string password = txtbox_password.Text;

            Users_Logic userlogic = new Users_Logic();

            User user = userlogic.getByEmail(email);
            //sisalbl.Text = u.roles.ToString();

            if (user!=null)
            {
                if (password == user.Password)
                {
                    //set up the account info here.
                    //admin view
                    dashboard.Show();
                    this.Hide();
                    //user view.
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                //if user doesnt not exist, show this message
                MessageBox.Show("the user does not exist.","", MessageBoxButtons.OK);
            }
            
            //send user to different forms(employee or customer) based on their roles            
        }

        private void sisalbl_Click(object sender, EventArgs e)
        {

        }


        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }
    }
}
