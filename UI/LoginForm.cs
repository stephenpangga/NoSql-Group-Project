using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            Btn_dashboard.Hide();
            Btn_incident.Hide();
            Btn_user.Hide();
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (username == "stephen" && password == "stephen")
            {
                DashboardForm dashboard = new DashboardForm();

                dashboard.Show();
                Hide();
            }
        }
    }
}
