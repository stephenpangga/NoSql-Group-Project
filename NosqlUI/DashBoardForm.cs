﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NosqlLogic;
using NosqlModel;
using NosqlModel.Enums;

namespace NosqlUI
{
    public partial class DashBoardForm : BaseForm
    {
        //List of Tickets
        Incident_Logic incident_Logic;
        List<Incident> inProcessTickets;
        List<Incident> unresolvedTickets;
        List<Incident> resolvedTickets;
        List<Incident> allTickets;
        List<Incident> urgentTickets;
        List<Incident> normalTickets;
        List<Incident> lowTickets;
        List<Incident> passDeadline;

        public DashBoardForm(User loggendUser)
        {
            InitializeComponent();
            //ticket_logic = new Ticket_Logic();
            incident_Logic = new Incident_Logic();

            //getting all different tickets
            allTickets = incident_Logic.getAllIncidents();
            inProcessTickets = incident_Logic.getInProcessTicketsFast();
            unresolvedTickets = incident_Logic.getUnResolvedTicketsFast();
            resolvedTickets = incident_Logic.getResolvedTicketsFast();

            //tickets by priority
            urgentTickets = incident_Logic.getUrgentTicketsFast();
            normalTickets = incident_Logic.getNormalTicketsFast();
            lowTickets = incident_Logic.getLowTicketsFast();
            passDeadline = incident_Logic.getPassDeadLineTicketsFast();

            //reset so the data is up to date next time
            incident_Logic.resetAll();

            this.currentUser = loggendUser;

            lbl_name.Text = $"Welcome {loggendUser.FirstName} {loggendUser.LastName}";

            fillCharts();

            //Unresolved Ticket box
            int urgent = urgentTickets.Count();
            int normal= normalTickets.Count();
            int low = lowTickets.Count();
            int expired = passDeadline.Count();

            lbl_urgent.Text += "\n\n" + urgent + "\n ";
            lbl_normal.Text += "\n\n" + normal + "\n ";
            lbl_low.Text += "\n\n" + low + "\n ";
            lbl_passdeadline.Text += "\n\n" + expired + "\n ";

            disableButton(btn_Dashboard);

        }

        private void fillCharts()
        {
            OverviewChart();
            fillUnresolvedChart();
            fillInProcessByIncidentChart();
            fillResolvedChart();
        }

        
        private Dictionary<NosqlModel.IncidentType.MainType, int> separateTicketsByIncidentType(List<Incident> tickets)
        {
            Dictionary<NosqlModel.IncidentType.MainType, int> types = new Dictionary<NosqlModel.IncidentType.MainType, int>();
            types.Add(NosqlModel.IncidentType.MainType.Hardware, 0);
            types.Add(NosqlModel.IncidentType.MainType.Software, 0);
            types.Add(NosqlModel.IncidentType.MainType.Service, 0);
            //add tickets depending on their incident type.
            foreach(Incident t in tickets)
            {
                types[t.incidentType.Main]++;
            }

            return types;
        }

        private void OverviewChart()
        {
            int resolved = resolvedTickets.Count();

            int unresolved = unresolvedTickets.Count();

            int inprocess = inProcessTickets.Count();

            overAllChart.Series["Series1"].Points.AddY(resolved); // number of resolved issues
            overAllChart.Series["Series1"].Points.AddY(unresolved);
            overAllChart.Series["Series1"].Points.AddY(inprocess);
            overAllChart.Series["Series1"].IsVisibleInLegend = false;

            overAllChart.Titles.Add("Ticket Overview");
            showPercentage(overAllChart);

            int i = 0;
            String[] s = { "\nResolved", "\nUnresolved", "\nIn Process" };
            foreach (DataPoint p in overAllChart.Series["Series1"].Points)
            {
                if (p.YValues[0] != 0)
                {
                    p.Label += s[i];
                }
                i++;
            }
        }

        //method unresolved tickets and resolved tickets
        //4 fill charts methods with different incident colors.
        //charts for each incidents.
        private void fillUnresolvedChart()
        {
            unResolvedChart.Titles.Add("Unresolved Tickets");
            fillByIncidentChart(unResolvedChart, unresolvedTickets, lbl_unresolved);
        }
        private void fillResolvedChart()
        {
            resolvedChart.Titles.Add("resolved tickets");
            fillByIncidentChart(resolvedChart, resolvedTickets, lbl_resolved);
        }
        private void fillInProcessByIncidentChart()
        {
            inProcessChart.Titles.Add("In process by incident");
            fillByIncidentChart(inProcessChart, inProcessTickets, lbl_inprocess);
        }

        public void fillByIncidentChart(Chart chartToEdit, List<Incident> tickets, Label lbl)
        {
            Dictionary<NosqlModel.IncidentType.MainType, int> types = separateTicketsByIncidentType(tickets);

            int hardware = types[NosqlModel.IncidentType.MainType.Hardware];
            int software = types[NosqlModel.IncidentType.MainType.Software];
            int service = types[NosqlModel.IncidentType.MainType.Service];
            int total = allTickets.Count() - (hardware + software + service);
            //int total = 10;

            chartToEdit.Series["Series1"].Points.AddY(hardware);
            chartToEdit.Series["Series1"].Points.AddY(software);
            chartToEdit.Series["Series1"].Points.AddY(service);
            chartToEdit.Series["Series1"].Points.AddY(total);

            lbl.Text = (hardware + software + service) + "/" + allTickets.Count();
            // lbl.Text = (hardware + software + service) + "/" + "10";

            showPercentage(chartToEdit);
            //add name for the charts
            showIncidentTypeLabels(chartToEdit);
        }

        private void showIncidentTypeLabels(Chart c)
        {
            int i = 0;
            String[] s = { "\nHardware", "\nSoftware", "\nService", "\nTickets" };
            foreach (DataPoint p in c.Series["Series1"].Points)
            {
                if (p.YValues[0] != 0)
                {
                    p.Label += s[i];
                }
                i++;
            }
        }

        //add percetage to chart
        private void showPercentage(Chart c)
        {
            c.Series["Series1"].IsValueShownAsLabel = true;

            foreach (DataPoint p in c.Series["Series1"].Points)
            {
                if(p.YValues[0] != 0)
                {
                    p.Label = "#PERCENT";
                }
                else
                {
                    p.Label = " ";
                }
            }
        }

        private void overAllChart_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {

        }
        //filter charts to incident view
        private void unResolvedChart_Click(object sender, EventArgs e)
        {
            IncidentManagment.getView(currentUser).SetFilter(IncidentManagment.getView(currentUser).UnresolvedIncident_ckbx);
            IncidentManagment.getView(currentUser).Show();
            
            this.Hide();
        }

        private void inProcessChart_Click(object sender, EventArgs e)
        {
            IncidentManagment.getView(currentUser).SetFilter(IncidentManagment.getView(currentUser).InProcessIncident_ckbx);
            IncidentManagment.getView(currentUser).Show();
            this.Hide();
        }
        private void resolvedChart_Click(object sender, EventArgs e)
        {
            IncidentManagment.getView(currentUser).SetFilter(IncidentManagment.getView(currentUser).resolvedIncident_ckbx);
            IncidentManagment.getView(currentUser).Show();
            this.Hide();
        }

        private void lbl_urgent_Click(object sender, EventArgs e)
        {
            IncidentManagment.getView(currentUser).SetFilter(IncidentManagment.getView(currentUser).urgentIncident_ckbx);
            IncidentManagment.getView(currentUser).Show();
            this.Hide();
        }

        private void btn_UserM_Click(object sender, EventArgs e)
        {

        }

        private void lbl_passdeadline_Click(object sender, EventArgs e)
        {
            IncidentManagment.getView(currentUser).SetFilter(IncidentManagment.getView(currentUser).pastDeadline_ckbx);
            IncidentManagment.getView(currentUser).Show();
            this.Hide();
        }
    }
}
