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
using NosqlModel.Enums;

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

            load();
            LoadData();
        }

        private void load()
        {
            incident_lstvw.GridLines = true;
            incident_lstvw.View = View.Details;

            //Add Column Header

            incident_lstvw.Columns.Add("Subject", 150);
            incident_lstvw.Columns.Add("Report date", 75);
            incident_lstvw.Columns.Add("Deadline", 75);
            incident_lstvw.Columns.Add("User", 75);
            incident_lstvw.Columns.Add("Type", 75);
            incident_lstvw.Columns.Add("Priority", 75);
            incident_lstvw.Columns.Add("Status", 75);

            LoadData();

            foreach (PriorityTypes priority in (PriorityTypes[])Enum.GetValues(typeof(PriorityTypes)))
            {
                incidentPriority_cbx.Items.Add(priority.ToString());
            }
            foreach (Status status in (Status[])Enum.GetValues(typeof(Status)))
            {
                incidentStatus_cbx.Items.Add(status);
            }
        }

        Incident_Logic incident_Logic = new Incident_Logic();
        private void LoadData()
        {
            List<Incident> incidents = incident_Logic.getAllIncidents();

            incident_lstvw.Items.Clear();

            foreach (Incident incident in incidents)
            {

                ListViewItem lv = new ListViewItem(incident.subject);
                lv.SubItems.Add(incident.reportDate.ToShortDateString());
                lv.SubItems.Add(incident.deadline.ToShortDateString());
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

        private void incident_lstvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (incident_lstvw.SelectedItems.Count == 1)
            {
                Incident incident = (Incident)incident_lstvw.SelectedItems[0].Tag;
                incidentDescription_rtbx.Text = incident.description;
                incidentMain_tbx.Text = incident.incidentType.Main.ToString();
                incidentSub_tbx.Text = incident.incidentType.Sub;
                incidentStatus_cbx.SelectedIndex = (int)incident.status;
                incidentPriority_cbx.SelectedIndex = (int)incident.priority;
            }
        }

        private void incidentUpdate_btn_Click(object sender, EventArgs e)
        {
            if (incident_lstvw.SelectedItems.Count == 1)
            {
                Incident incident = (Incident)incident_lstvw.SelectedItems[0].Tag;
                incident.description = incidentDescription_rtbx.Text;
                incident.status = (Status)incidentStatus_cbx.SelectedIndex;
                incident.priority = (PriorityTypes)incidentPriority_cbx.SelectedIndex;
                incident_Logic.UpdateIncident(incident);
            }
            LoadData();
        }

        private void incidentDelete_btn_Click(object sender, EventArgs e)
        {
            if (incident_lstvw.SelectedItems.Count == 1)
            {
                Incident incident = (Incident)incident_lstvw.SelectedItems[0].Tag;
                incident_Logic.DeleteIncident(incident.id);
            }
            LoadData();
        }
    }
}
