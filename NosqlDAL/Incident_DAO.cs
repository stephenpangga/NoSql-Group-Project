﻿using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace NosqlDAL
{
    public class Incident_DAO : Base
    {
        
        public List<Incident> GetAllIncidents()
        {
            return readIncidents(GetAll(IncidentColl));
        }

        public List<Incident> GetAllIncidents(FilterDefinition<BsonDocument> filter)
        {
            return readIncidents(GetSpecificDocumentList(IncidentColl,filter));
        }

        private List<Incident> readIncidents(List<BsonDocument> documents)
        {
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
            return readIncidents(GetSpecificDocumentsList(IncidentColl, searchTerm, "IncidentUser"));
        }

        private IncidentType GetIncidentType(string main, string sub)
        {
            foreach(IncidentType category in IncidentType.categories)
            {
                if(category.Sub.Equals(sub) && category.Main.ToString().Equals(main))
                {
                    return category;
                }
            }
            return IncidentType.Uncategorised;
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

        //get incidents with different status - by stephen
        public List<Incident> getSpecificIncidentTickets(string ticketStatus, string column)
        {
            return readIncidents(GetSpecificDocumentList(IncidentColl, ticketStatus, column));
        }
        public bool UpdateIncident(ObjectId searchValue, string attribute, string updateValue, string column)
        {
            var result = UpdateDocument(IncidentColl, searchValue, attribute, updateValue, column);
            return result;
            
        }

        public void DeleteIncident(ObjectId searchValue, string attribute)
        {
            deleteData(searchValue, attribute, IncidentColl);
        }
    }

    
}
