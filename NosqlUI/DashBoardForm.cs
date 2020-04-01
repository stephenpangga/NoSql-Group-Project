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
            
            int totalticket = countTickets();
            chart1.Series["Series1"].Points.AddY(1); // number of resolved issues
            chart1.Series["Series1"].Points.AddY(totalticket); // number of unresolved issues
            chart1.Series["Series1"].IsVisibleInLegend = false;

            //lbl_amount.Text = totalticket.ToString();
           
        }

        private int countTickets()
        {
            Ticket_Logic tickets = new Ticket_Logic();

            List<Ticket> listofTickets = tickets.getResolvedTickets();

            int count = 0;

            foreach(Ticket t in listofTickets)
            {
                count++;
            }

            lbl_amount.Text = listofTickets.Count().ToString();

            count = listofTickets.Count();

            return count;
        }

        //method unresolved tickets and resolved tickets

        //method
        //4 fill charts methods with different incident colors.


        //charts for each incidents.

    }
}
