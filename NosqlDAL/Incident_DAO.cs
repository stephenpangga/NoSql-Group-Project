using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Bson;
using NosqlModel;

namespace NosqlDAL
{
    public class Incident_DAO : Base
    {
        
        public List<Incident> GetIncidents()
        {
            var documents = GetAll(IncidentColl);

            List<Incident> incidents = new List<Incident>();

            foreach (var document in documents)
            {
                Incident incident = new Incident()
                {
                    id = (ObjectId)document["_id"],
                    subject = document["Subject"].ToString(),
                    reportDate = DateTime.Parse(document["ReportDate"].ToString()),
                    incidentType = GetIncidentType(document["IncidentMainType"].ToString(), document["IncidentSubType"].ToString()),
                    incidentUser = GetUserData((ObjectId)document["IncidentUser"]),
                    priority = (NosqlModel.Enums.PriorityTypes)Enum.Parse(typeof(NosqlModel.Enums.PriorityTypes), document["Priority"].ToString()),
                    deadline = DateTime.Parse(document["Deadline"].ToString()),
                    description = document["Description"].ToString(),
                    status = (NosqlModel.Enums.Status)Enum.Parse(typeof(NosqlModel.Enums.Status), document["Status"].ToString())

                };
                incidents.Add(incident);
            }

            return incidents;
        }

        public List<Incident> GetTicketsForCustomer(ObjectId searchTerm)
        {
            var documents = GetSpecificDocumentsList(IncidentColl, searchTerm, "IncidentUser");

            List<Incident> tickets = new List<Incident>();

            foreach (var document in documents)
            {
                Incident incident = new Incident()
                {
                    id = (ObjectId)document["_id"],
                    subject = document["Subject"].ToString(),
                    reportDate = DateTime.Parse(document["ReportDate"].ToString()),
                    incidentType = GetIncidentType(document["IncidentMainType"].ToString(), document["IncidentSubType"].ToString()),
                    incidentUser = GetUserData((ObjectId)document["IncidentUser"]),
                    priority = (NosqlModel.Enums.PriorityTypes)Enum.Parse(typeof(NosqlModel.Enums.PriorityTypes), document["Priority"].ToString()),
                    deadline = DateTime.Parse(document["Deadline"].ToString()),
                    description = document["Description"].ToString(),
                    status = (NosqlModel.Enums.Status)Enum.Parse(typeof(NosqlModel.Enums.Status), document["Status"].ToString())

                };
                tickets.Add(incident);
            }

            return tickets;
        }

        private IncidentType GetIncidentType(string main, string sub)
        {
            foreach(IncidentType category in IncidentType.categories)
            {
                if(category.Sub == sub && category.Main.ToString() == main)
                {
                    return category;
                }
            }
            throw new Exception("IncidentType not found");
        }

        private User GetUserData(ObjectId id)
        {
            Users_DAO users_DAO = new Users_DAO();
            return users_DAO.GetUser(UserColl , id);
        }
        public void CreateIncident(Incident incident)
        {
            BsonDocument document = new BsonDocument();
            document["Subject"] = incident.subject;
            document["ReportDate"] = incident.reportDate;
            document["IncidentMainType"] = incident.incidentType.Main.ToString();
            document["IncidentSubType"] = incident.incidentType.Sub;
            document["IncidentUser"] = incident.incidentUser.id;
            document["Priority"] = incident.priority.ToString();
            document["Deadline"] = incident.deadline;
            document["Description"] = incident.description;
            document["Status"] = incident.status.ToString();

            InsertOne(document, IncidentColl);
        }

        //clean this later.
        public Incident SearchByEmail(string Email)
        {
            try
            {
                Incident incident = new Incident();
                //var document = SearchByString("Incident", Email, "email");

                //admin.Email = document["email"].ToString();
                //admin.FirstName = document["firstName"].ToString();
                //admin.Password = document["password"].ToString();

                return incident;
            }
            catch
            {
                return null;
            }
        }

        //get incidents with different status - by stephen
        public List<Incident> getSpecificIncidentTickets(string ticketStatus, string column)
        {
            List<Incident> incidents = new List<Incident>();
            var document = GetSpecificDocumentList(IncidentColl, ticketStatus, column);
            foreach (var info in document)
            {
                ObjectId id = (ObjectId)info["_id"];
                string subject = info["Subject"].ToString();
                DateTime reportDate = DateTime.Parse(info["ReportDate"].ToString());
                IncidentType.MainType mainType = (IncidentType.MainType)Enum.Parse(typeof(IncidentType.MainType), info["IncidentMainType"].ToString());
                IncidentType incidentType = new IncidentType(mainType);
               // IncidentType incidentType = GetIncidentType(info["IncidentMainType"].ToString(), info["IncidentSubType"].ToString());
                User incidentUser = GetUserData((ObjectId)info["IncidentUser"]);
                NosqlModel.Enums.PriorityTypes priority = (NosqlModel.Enums.PriorityTypes)Enum.Parse(typeof(NosqlModel.Enums.PriorityTypes), info["Priority"].ToString());
                DateTime deadline = DateTime.Parse(info["Deadline"].ToString());
                string description = info["Description"].ToString();
                NosqlModel.Enums.Status status = (NosqlModel.Enums.Status)Enum.Parse(typeof(NosqlModel.Enums.Status), info["Status"].ToString());

                Incident incident = new Incident(id, reportDate, subject, incidentType, incidentUser, priority, deadline, description, status);

                incidents.Add(incident);
            }
            return incidents;
        }

        //fixed get all method, fuck you jesse ffs
        public List<Incident> getAllIncidents()
        {
            var documents = GetAll(IncidentColl);

            List<Incident> incidents = new List<Incident>();

            foreach (var info in documents)
            {
                ObjectId id = (ObjectId)info["_id"];
                string subject = info["Subject"].ToString();
                DateTime reportDate = DateTime.Parse(info["ReportDate"].ToString());
                IncidentType.MainType mainType = (IncidentType.MainType)Enum.Parse(typeof(IncidentType.MainType), info["IncidentMainType"].ToString());
                IncidentType incidentType = new IncidentType(mainType);
                User incidentUser = GetUserData((ObjectId)info["IncidentUser"]);
                NosqlModel.Enums.PriorityTypes priority = (NosqlModel.Enums.PriorityTypes)Enum.Parse(typeof(NosqlModel.Enums.PriorityTypes), info["Priority"].ToString());
                DateTime deadline = DateTime.Parse(info["Deadline"].ToString());
                string description = info["Description"].ToString();
                NosqlModel.Enums.Status status = (NosqlModel.Enums.Status)Enum.Parse(typeof(NosqlModel.Enums.Status), info["Status"].ToString());

                Incident incident = new Incident(id, reportDate, subject, incidentType, incidentUser, priority, deadline, description, status);

                incidents.Add(incident);
            }

            return incidents;
        }
    }
}
