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

namespace NosqlUI
{
    public partial class IncidentReport : BaseForm
    {
        public IncidentReport()
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
        }


        // need to send to dal
        //creates an incident and sends it to the database
        private void incidentSubmit_btn_Click(object sender, EventArgs e) 
        {
            Incident incident = new Incident()
            {
                subject = incidentSubject_txtbx.Text,
                reportDate = incidentDate_dtp.Value,
                incidentUser = currentUser,
                priority = (PriorityType)incidentPriority_cbx.SelectedIndex,
                Description = incidentDescription_rtxtbx.Text
            };

            incident.SetDeadline(incidentDeadline_cbx.Text);
            
            foreach (IncidentType category in IncidentType.categories)
            {
                if (category.Sub == incidentSubType_cbx.Text && category.Main.ToString() == incidentType_cbx.Text)
                {
                    incident.incidentType = category;
                }
            }
            
        }

        private void incidentType_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
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
