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
    public partial class CustomerDashboard : Form
    {
        Customers_Logic customers_Logic = new Customers_Logic();
        List<Ticket> tickets = new List<Ticket>();
        public CustomerDashboard()
        {
            InitializeComponent();
            FillListView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void FillListView()
        {
            //user will be sent from login to be used here
            tickets = customers_Logic.FetchEmployeeTickets("Tickets","Hank","Reported by");

            //dataList.Clear();
            dataList.Columns.Add("Subject", 86);
            dataList.Columns.Add("Description", 120);
            dataList.Columns.Add("Status", 160);
            dataList.Columns.Add("Deadline", 120);
            dataList.Columns.Add("Incident type", 240);

            foreach (Ticket ticket in tickets)
            {
                var item = new string[5] { ticket.Subject.ToString(),ticket.Description,ticket.Status.ToString(),ticket.Deadline.ToString(), ticket.IncidentType.ToString() };

                dataList.Items.Add(new ListViewItem(item));
            }

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
