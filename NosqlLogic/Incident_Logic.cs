using System;
using System.Collections.Generic;
using System.Text;
using NosqlDAL;
using NosqlModel;
using MongoDB.Bson;


namespace NosqlLogic
{
    public class Incident_Logic
    {
        Incident_DAO incident_dao = new Incident_DAO();

        public List<Incident> getAllIncidents()
        {
            return incident_dao.GetIncidents();
        }

        public void InsertIncident(Incident incident)
        {
            incident_dao.CreateIncident(incident);


        }

        //stephen stuff COPIED FROM TICKET LOGIC BC JESSE HAS TO MAKE A NEW CLASS 2 DAYS BEFORE THE DEADLINE INSTEAD OF USING WHAT
        //WE ALREADY MADE LONG BEFORE
        //ticket status
        public List<Incident> getResolvedTickets()
        {
            return incident_dao.getSpecificIncidentTickets("Resolved", "Status");
        }

        public List<Incident> getUnResolvedTickets()
        {
            return incident_dao.getSpecificIncidentTickets("Unresolved", "Status");
        }

        public List<Incident> getInProcessTickets()
        {
            return incident_dao.getSpecificIncidentTickets("InProcess", "Status");
        }
        //based on priority
        public List<Incident> getUrgentTickets()
        {
            List<Incident> urgentIncident = incident_dao.getSpecificIncidentTickets("High", "Priority");

            List<Incident> unresolvedUrgetTickets = new List<Incident>();

            for (int i = 0; i < urgentIncident.Count; i++)
            {
                if (urgentIncident[i].status == NosqlModel.Enums.Status.Unresolved)
                {
                    //urgentIncident.RemoveAt(i);
                    unresolvedUrgetTickets.Add(urgentIncident[i]);
                }
            }

            return unresolvedUrgetTickets;
            //return incident_dao.getSpecificIncidentTickets("High", "Priority");
        }

        //separate get all
        public List<Incident> getAll()
        {
            return incident_dao.getAllIncidents();
        }
        public List<Incident> FetchEmployeeTickets(ObjectId searchTerm)
        {
            return incident_dao.GetTicketsForCustomer(searchTerm);
        }

    }
}