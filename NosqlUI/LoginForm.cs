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
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            //hide the base buttons
            btn_dash.Hide();
            btn_incident.Hide();
            btn_userM.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DashBoardForm dashboard = new DashBoardForm();

            //send user to different forms(employee or customer) based on their roles

            dashboard.Show();
            this.Hide();
        }
    }
}
