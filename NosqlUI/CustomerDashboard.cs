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
        Incident_Logic incident_Logic = new Incident_Logic();
        List<Incident> incidents = new List<Incident>();
        User loggedInUser;
        public CustomerDashboard(User currentUser)
        {
            InitializeComponent();
            FillListView(currentUser);
            lbl_EmployeeName.Text = currentUser.FirstName;
            loggedInUser = currentUser;
            
        }

        void FillListView(User user)
        {

            //user will be sent from login to be used here
            //tickets will be get using fullname to make it uniqe
            incidents = incident_Logic.FetchEmployeeTickets(user.id);

            //dataList.Clear();
            dataListView.Columns.Add("Subject", 140);
            dataListView.Columns.Add("Reported by", 120);
            dataListView.Columns.Add("Reported date", 160);
            dataListView.Columns.Add("Deadline", 120);
            dataListView.Columns.Add("Status", 100);
            dataListView.Columns.Add("Priority", 100);

            foreach (Incident incident in incidents)
            {
                var item = new string[6] { incident.subject, incident.incidentUser.FirstName,incident.reportDate.ToString(),incident.deadline.ToString(),incident.status.ToString(),incident.priority.ToString()};

                dataListView.Items.Add(new ListViewItem(item));
            }

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerChangeInfoForm changeInfoForm = new CustomerChangeInfoForm(loggedInUser.id);
            changeInfoForm.Show();
        }

        private void dataListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm logInForm = new LoginForm();
            logInForm.Show();
        }
    }
}
