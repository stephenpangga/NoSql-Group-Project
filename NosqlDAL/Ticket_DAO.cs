﻿using System;
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

        //get tickets with different status
        public List<Ticket> getSpecificTickets(string ticketStatus, string column)
        {
            List<Ticket> tickets = new List<Ticket>();
            var document = GetSpecificDocumentsList("Tickets",ticketStatus, column);
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
            var document = GetSpecificDocumentsList("Tickets", incident, "Incidenttype");
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
