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

        }

        //to hide the buttons not needed for some forms
        public void hideButtons()
        {
            btn_Dashboard.Hide();
            btn_IncidentM.Hide();
            btn_UserM.Hide();
        }

        //disable button for current view
        protected void disableButton(Button btn)
        {
            btn_Dashboard.Enabled = true;
            btn_IncidentM.Enabled = true;
            btn_UserM.Enabled = true;

            btn.Enabled = false;
        }

        private void btn_IncidentM_Click(object sender, EventArgs e)
        {
            IncidentManagment.getView().Show();
            this.Hide();
            IncidentManagment.getView().disableButton(btn_IncidentM);
        }

        private void btn_UserM_Click(object sender, EventArgs e)
        {
            CustomerManagement cm = new CustomerManagement();
            cm.Show();
            this.Hide();
        }

    }
}
