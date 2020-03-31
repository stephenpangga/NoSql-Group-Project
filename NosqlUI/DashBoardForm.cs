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
        public DashBoardForm(User loggendUser)
        {
            InitializeComponent();
            //Users_Logic userlogic = new Users_Logic();
            //User u = userlogic.SearchUser("Users", "admin");
            lbl_name.Text = $"Welcome {loggendUser.FirstName} {loggendUser.LastName}";
            
            countTickets();
        }

        private void countTickets()
        {
            Ticket_Logic tickets = new Ticket_Logic();

            List<Ticket>listofTickets = tickets.getTickets();

            int count = 0;

            foreach(Ticket t in listofTickets)
            {
                count++;
            }

            lbl_amount.Text = listofTickets.Count().ToString() ;
        }

    }
}
