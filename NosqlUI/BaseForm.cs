﻿using NosqlLogic;
using NosqlModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NosqlUI
{
    public partial class BaseForm : Form
    {
        public User currentUser;

        public BaseForm() // for when no one is logged in
        {
            InitializeComponent();

        }
        public BaseForm(User user) // for when someone is logged in
        {
            InitializeComponent();
            this.currentUser = user;

        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            DashBoardForm d = new DashBoardForm(currentUser);
            d.Show();
            this.Hide();
        }

        //to hide the buttons not needed for some forms
        public void hideButtons()
        {
            btn_Dashboard.Hide();
            btn_IncidentM.Hide();
            btn_UserM.Hide();
            linegrBox.Hide();
            btn_logout.Hide();
        }

        //disable button for current view
        protected void disableButton(Button btn)
        {
            btn_Dashboard.Enabled = true;
            btn_IncidentM.Enabled = true;
            btn_UserM.Enabled = true;
            btn_logout.Enabled = true;

            btn.Enabled = false;
        }

        private void btn_IncidentM_Click(object sender, EventArgs e)
        {
            Incident_Logic incident_Logic = new Incident_Logic();
            IncidentManagment.getView(currentUser).Show();
            this.Hide();

        }

        private void btn_UserM_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement(currentUser);
            cm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm logInForm = LoginForm.getView();
            logInForm.Show();
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.getView().Show();
        }
    }
}
