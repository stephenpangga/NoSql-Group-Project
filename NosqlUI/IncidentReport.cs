using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NosqlModel;
using NosqlLogic;

namespace NosqlUI
{
    public partial class IncidentReport : BaseForm
    {
        private static IncidentReport view;
        public static IncidentReport getView()
        {
            if (view == null)
            {
                view = new IncidentReport();
            }
            return view;
        }

        Incident_Logic Incident_Logic = new Incident_Logic();
        public IncidentReport() : base()
        {
            InitializeComponent();
            incidentSubType_cbx.Hide();
            foreach (IncidentType.MainType mainType in (IncidentType.MainType[])Enum.GetValues(typeof(IncidentType.MainType)))
            {
                incidentType_cbx.Items.Add(mainType);
            }
            foreach (DeadlineType deadline in DeadlineType.deadlines)
            {
                incidentDeadline_cbx.Items.Add(deadline.Text);
            }

            Customers_Logic users_Logic = new Customers_Logic();
            foreach (User user in users_Logic.getAllEmployees())
            {
                incidentUser_cbx.Items.Add(new ComboItem(user.FirstName,user));
            }
        }


        // need to send to dal
        //creates an incident and sends it to the database
        private void incidentSubmit_btn_Click(object sender, EventArgs e) 
        {
            Incident incident = new Incident()
            {
                subject = incidentSubject_txtbx.Text,
                reportDate = incidentDate_dtp.Value,
                incidentUser = (incidentUser_cbx.SelectedItem as ComboItem).m_user,
                priority = (NosqlModel.Enums.PriorityTypes)incidentPriority_cbx.SelectedIndex,
                description = incidentDescription_rtxtbx.Text
            };

            incident.SetDeadline(incidentDeadline_cbx.Text);

            foreach (IncidentType category in IncidentType.categories)
            {
                if (category.Sub == incidentSubType_cbx.Text && category.Main.ToString() == incidentType_cbx.Text)
                {
                    incident.incidentType = category;
                }
            }

            Incident_Logic.InsertIncident(incident);
        }

        private void incidentType_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            incidentSubType_cbx.Show();
            foreach (IncidentType categorie in IncidentType.categories)
            {
                if (categorie.Main.ToString() == incidentType_cbx.Text)
                {
                    incidentSubType_cbx.Items.Add(categorie.Sub);
                }
            }
        }
    }
}
