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

        public List<Incident> FetchEmployeeTickets(ObjectId searchTerm)
        {
            return incident_dao.GetTicketsForCustomer( searchTerm);
        }
    }
}
