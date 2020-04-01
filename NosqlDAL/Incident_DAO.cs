using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Bson;


namespace NosqlDAL
{
    public class Incident_DAO : Base
    {
        public readonly string COLLECTION = "Incidents";
        public List<Incident> GetIncidents()
        {
            var documents = GetAll(COLLECTION);

            List<Incident> incidents = new List<Incident>();

            foreach (var document in documents)
            {
                Incident incident = new Incident()
                {
                    subject = document["Subject"].ToString(),
                    reportDate = DateTime.Parse(document["ReportDate"].ToString()),
                    incidentType = GetIncidentType(document["IncidentMainType"].ToString(), document["IncidentSubType"].ToString()),
                    incidentUser = GetUserData(int.Parse(document["IncidentUser"].ToString())),
                    priority = (NosqlModel.Enums.PriorityTypes)Enum.Parse(typeof(NosqlModel.Enums.PriorityTypes), document["Priority"].ToString()),
                    deadline = DateTime.Parse(document["Deadline"].ToString()),
                    description = document["Description"].ToString(),
                    status = (NosqlModel.Enums.Status)Enum.Parse(typeof(NosqlModel.Enums.Status), document["Status"].ToString())

                    //entType = (IncidentType)Enum.Parse(typeof(IncidentType), doc["Incidenttype"].ToString())
                };
                incidents.Add(incident);
            }

            return incidents;
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

        private User GetUserData(int id)
        {
            Users_DAO users_DAO = new Users_DAO();
            return users_DAO.GetUser(users_DAO.COLLECTION , id);
        }
        public void CreateIncident(Incident incident)
        {
            BsonDocument document = new BsonDocument();
            document["Subject"] = incident.subject;
            document["ReportDate"] = incident.reportDate;
            document["IncidentMainType"] = incident.incidentType.Main;
            document["IncidentSubType"] = incident.incidentType.Sub;
            document["IncidentUser"] = incident.incidentUser.userId;
            document["Priority"] = incident.priority;
            document["Deadline"] = incident.deadline;
            document["Description"] = incident.description;
            document["Status"] = incident.status;

            InsertOne(document, COLLECTION);
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
    }

}
