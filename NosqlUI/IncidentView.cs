﻿using System;
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
    public partial class IncidentManagment : BaseForm
    {
        // makes incidentManagment accesible from anywhere
        private static IncidentManagment view;
        List<Incident> incidents;

        //im passing on the ticket list here, so that i can show different filtered incident. -stephen
        public static IncidentManagment getView(List<Incident> incidents)
        {
            if (view == null)
            {
                view = new IncidentManagment(incidents);
            }
            return view;
        }
        public IncidentManagment(List<Incident> incidents)
        {
            this.incidents = incidents;
            InitializeComponent();
            loadListView();
            LoadData();
        }

        //this method is never called. so delete it if you want. -stephen
        private void IncidentManagment_Load(object sender, EventArgs e)
        {
            incident_lstvw.GridLines = true;
            incident_lstvw.View = View.Details;

            //Add Column Header

            incident_lstvw.Columns.Add("Subject", 150);
            incident_lstvw.Columns.Add("Report date", 150);
            incident_lstvw.Columns.Add("Deadline", 150);
            incident_lstvw.Columns.Add("User", 150);
            incident_lstvw.Columns.Add("Type", 150);
            incident_lstvw.Columns.Add("Priority", 150);
            incident_lstvw.Columns.Add("Status", 150);

            LoadData();
        }

        private void loadListView()
        {
            incident_lstvw.GridLines = true;
            incident_lstvw.View = View.Details;

            //Add Column Header

            incident_lstvw.Columns.Add("Subject", 150);
            incident_lstvw.Columns.Add("Report date", 150);
            incident_lstvw.Columns.Add("Deadline", 150);
            incident_lstvw.Columns.Add("User", 150);
            incident_lstvw.Columns.Add("Type", 150);
            incident_lstvw.Columns.Add("Priority", 150);
            incident_lstvw.Columns.Add("Status", 150);
        }


        private void LoadData()
        {
            Incident_Logic incident_Logic = new Incident_Logic();
            //List<Incident> incidents = incident_Logic.getAllIncidents();

            incident_lstvw.Items.Clear();

            foreach (Incident incident in incidents)
            {

                ListViewItem lv = new ListViewItem(incident.subject);
                //lv.SubItems.Add();
                lv.SubItems.Add(incident.reportDate.ToString());
                lv.SubItems.Add(incident.deadline.ToString());
                lv.SubItems.Add(incident.incidentUser.FirstName + " " + incident.incidentUser.LastName);
                lv.SubItems.Add(incident.incidentType.Main.ToString());
                lv.SubItems.Add(incident.priority.ToString());
                lv.SubItems.Add(incident.status.ToString());
                lv.Tag = incident;
                incident_lstvw.Items.Add(lv);
            }

        }

        private void incidentCreate_btn_Click(object sender, EventArgs e)
        {
            IncidentReport.getView().Show();
        }
    }
}
