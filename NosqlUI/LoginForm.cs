﻿using System;
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
        private static LoginForm view;
        public static LoginForm getView()
        {
            if (view == null || view.IsDisposed)
            {
                view = new LoginForm();
            }
            return view;
        }
        private LoginForm()
        {
            InitializeComponent();
            hideButtons();
            //hide the base buttons
            //Users_Logic userlogic = new Users_Logic();
            //User u = userlogic.SearchUser("Users", "admin");
            //User u = userlogic.getByEmail("useratgmaisl.com");
            txtbox_password.PasswordChar = '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //DashBoardForm dashboard = new DashBoardForm();

            //user info
            string email = txtbox_email.Text;
            string password = txtbox_password.Text;

            Users_Logic userlogic = new Users_Logic();

            User user = userlogic.getByEmail(email);

            if (user!=null)
            {
                //need to make method to unhash password.
                if (password == user.Password)
                {
                    //set up the account info here. need to  see what tim use here
                    currentUser = user;
                    switch(user.roles)
                    {
                        //admin view
                        case NosqlModel.Enums.Roles.Admin:
                            DashBoardForm dashboardForm = new DashBoardForm(currentUser);
                            dashboardForm.Show();
                            break;
                        //user view.
                        case NosqlModel.Enums.Roles.Employee:
                            CustomerDashboard customerDashBoard = new CustomerDashboard(currentUser);
                            customerDashBoard.Show();
                            break;
                    }
                    this.Hide();
                    txtbox_email.Text = "";
                    txtbox_password.Text = "";
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                //if user doesnt not exist, show this message
                MessageBox.Show("The user does not exist.","", MessageBoxButtons.OK);
            }
            
            //send user to different forms(employee or customer) based on their roles            
        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void link_resetpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm forgotPassForm = new ForgotPassForm();
            forgotPassForm.Show();
        }
    }
}
