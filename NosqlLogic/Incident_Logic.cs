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
        List<Incident> all;

        public List<Incident> getAllIncidents()
        {
            all = incident_dao.GetIncidents();
            return all;
        }

        public void InsertIncident(Incident incident)
        {
            incident_dao.CreateIncident(incident);
        }

        //stephen stuff COPIED FROM TICKET LOGIC BC JESSE HAS TO MAKE A NEW CLASS 2 DAYS BEFORE THE DEADLINE INSTEAD OF USING WHAT
        //WE ALREADY MADE LONG BEFORE
        //ticket status
        // These methods are for getting filtered lists directly from the database, which is very slow with the database we are using
        // therefore we are using local filtering instead for this project (see at the bottom)
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

        public List<Incident> getPastDeadlineTickets()
        {
            return incident_dao.getSpecificIncidentTickets("PastDeadLine", "Status");
        }


        public List<Incident> FetchEmployeeTickets(ObjectId searchTerm)
        {
            return incident_dao.GetTicketsForCustomer(searchTerm);
        }

        public bool UpdateIncident(Incident incident)
        {
            bool result = incident_dao.UpdateIncident(incident.id, "_id", incident.status.ToString(), "Status");
            if (result)
                result = incident_dao.UpdateIncident(incident.id, "_id", incident.priority.ToString(), "Priority");
            if (result)
                result = incident_dao.UpdateIncident(incident.id, "_id", incident.description, "Description");

            return result;

        }

        public void DeleteIncident(ObjectId _id)
        {
            incident_dao.DeleteIncident(_id,"_id");
        }

        //local filtering version a bit faster than getting everything from the database.

        public List<Incident> filterByStatus(NosqlModel.Enums.Status status)
        {
            if(all == null)
            {
                all = getAllIncidents();
            }

            List<Incident> filtered = new List<Incident>();
            for (int i = 0; i < all.Count; i++)
            {
                if (all[i].status == status)
                {
                    //urgentIncident.RemoveAt(i);
                    filtered.Add(all[i]);
                }
            }
            return filtered;
        }

        public List<Incident> getResolvedTicketsFast()
        {
            return filterByStatus(NosqlModel.Enums.Status.Resolved);
        }
        
        public List<Incident> getUnResolvedTicketsFast()
        {
            return filterByStatus(NosqlModel.Enums.Status.Unresolved);
        }
        
        public List<Incident> getInProcessTicketsFast()
        {
            return filterByStatus(NosqlModel.Enums.Status.InProcess);
        }
        public List<Incident> getPassDeadLineTicketsFast()
        {
            return filterByStatus(NosqlModel.Enums.Status.PastDeadLine);
        }


        //filtering tickets by its priority leve
        public List<Incident> filterByPriorityUnresolved(NosqlModel.Enums.PriorityTypes priority)
        {
            if (all == null)
            {
                all = getAllIncidents();
            }
            List<Incident> filtered = new List<Incident>();

            for (int i = 0; i < all.Count; i++)
            {
                if (all[i].status == NosqlModel.Enums.Status.Unresolved && all[i].priority == priority)
                {
                    //urgentIncident.RemoveAt(i);
                    filtered.Add(all[i]);
                }
            }
            return filtered;
        }

        public List<Incident> getUrgentTicketsFast()
        {
            return filterByPriorityUnresolved(NosqlModel.Enums.PriorityTypes.High);
        }
        
        public List<Incident> getNormalTicketsFast()
        {
            return filterByPriorityUnresolved(NosqlModel.Enums.PriorityTypes.Normal);
        }
        
        public List<Incident> getLowTicketsFast()
        {
            return filterByPriorityUnresolved(NosqlModel.Enums.PriorityTypes.Low);
        }

    }

}
