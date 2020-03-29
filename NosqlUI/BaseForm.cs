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
    }
}
