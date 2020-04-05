using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using NosqlModel.Enums;

namespace NosqlDAL
{
    public class Ticket_DAO : Base
    {
        //not sure if this will work, just trying.
        public List<Ticket> getTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            var document = GetAll("Tickets");
            foreach (var info in document)
            {
                string subject = info["Subject"].ToString();
                string description = info["Description"].ToString();
                Status status = (Status)Enum.Parse(typeof(Status), info["Status"].ToString());
                int deadline = int.Parse(info["Deadline"].ToString());
                NosqlModel.Enums.IncidentType incidentType = (NosqlModel.Enums.IncidentType)Enum.Parse(typeof(NosqlModel.Enums.IncidentType), info["Incidenttype"].ToString());

                Ticket ticket = new Ticket(subject, description, status, deadline, incidentType);

                tickets.Add(ticket);
            }
            return tickets;
        }

        //get ticket based on incident type
        public List<Ticket> getIncidentTicket(string incident)
        {
            List<Ticket> tickets = new List<Ticket>();
            var document = GetSpecificDocumentList("Tickets", incident, "Incidenttype");
            foreach (var info in document)
            {
                string subject = info["Subject"].ToString();
                string description = info["Description"].ToString();
                Status status = (Status)Enum.Parse(typeof(Status), info["Status"].ToString());
                int deadline = int.Parse(info["Deadline"].ToString());
                NosqlModel.Enums.IncidentType incidentType = (NosqlModel.Enums.IncidentType)Enum.Parse(typeof(NosqlModel.Enums.IncidentType), info["Incidenttype"].ToString());

                Ticket ticket = new Ticket(subject, description, status, deadline, incidentType);

                tickets.Add(ticket);
            }
            return tickets;
        }
        
    }
}
