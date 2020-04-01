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

            //int totalticket = countTickets();
            //chart1.Series["Series1"].Points.AddY(1); // number of resolved issues
            //chart1.Series["Series1"].Points.AddY(totalticket); // number of unresolved issues
            //chart1.Series["Series1"].IsVisibleInLegend = false;

            //lbl_amount.Text = totalticket.ToString();
            OverviewChart();
            UnresolvedChart();
           
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

        Ticket_Logic tickets = new Ticket_Logic();

        private void OverviewChart()
        {
            int totalTicket = tickets.getTickets().Count();

            int resolved = tickets.getResolvedTickets().Count();

            int unresolved = tickets.getUnResolvedTickets().Count();

            int inprocess = tickets.getInProcessTickets().Count();

            int overalltickets = totalTicket - (resolved + unresolved + inprocess);

            chart1.Series["Series1"].Points.AddY(resolved); // number of resolved issues
            chart1.Series["Series1"].Points.AddY(unresolved);
            chart1.Series["Series1"].Points.AddY(inprocess);
            chart1.Series["Series1"].Points.AddY(overalltickets); // number of unresolved issues
            chart1.Series["Series1"].IsVisibleInLegend = false;

            chart1.Titles.Add("Ticket Overview");
        }

        //method unresolved tickets and resolved tickets
        //4 fill charts methods with different incident colors.
        //charts for each incidents.
        private void UnresolvedChart()
        {
            int totalTicket = tickets.getTickets().Count();
            int unresolved = tickets.getUnResolvedTickets().Count();


            int overalltickets = totalTicket - (unresolved);
            UnresolvedPie.Series["Series1"].Points.AddY(unresolved);
            UnresolvedPie.Series["Series1"].Points.AddY(overalltickets); // number of unresolved issues

            UnresolvedPie.Series["Series1"].IsVisibleInLegend = false;
            UnresolvedPie.Titles.Add("Unresolved Tickets");
        }

    }
}
