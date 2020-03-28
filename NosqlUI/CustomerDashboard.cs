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
        CustomerChangeInfoForm changeInfoForm = new CustomerChangeInfoForm();
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
            tickets = customers_Logic.FetchEmployeeTickets("Tickets","Hank","Reportedby");

            //dataList.Clear();
            dataListView.Columns.Add("Subject", 140);
            dataListView.Columns.Add("Description", 120);
            dataListView.Columns.Add("Status", 160);
            dataListView.Columns.Add("Deadline", 120);
            dataListView.Columns.Add("Incident type", 240);

            foreach (Ticket ticket in tickets)
            {
                var item = new string[5] { ticket.Subject.ToString(),ticket.Description,ticket.Status.ToString(),ticket.Deadline.ToString(), ticket.IncidentType.ToString() };

                dataListView.Items.Add(new ListViewItem(item));
            }

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeInfoForm.Show();
        }
    }
}
