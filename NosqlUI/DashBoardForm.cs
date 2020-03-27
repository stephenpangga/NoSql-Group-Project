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
    public partial class DashBoardForm : BaseForm
    {
        public DashBoardForm()
        {
            InitializeComponent();

            
            Users_Logic userlogic = new Users_Logic();
            User u = userlogic.SearchUser("Users", "admin");
            
        }
    }
}
