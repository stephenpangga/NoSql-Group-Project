using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlModel.Enums;


namespace NosqlDAL
{
    class Customer_DAO : Base
    {
        public List<Ticket> GetTicketsForEmployee(string Coll, string searchTerm, string attribute)
        {
            var documents = GetSpecificDocumentsList(Coll, searchTerm, attribute);

            List<Ticket> tickets = new List<Ticket>();

            foreach(var doc in documents)
            {
                Ticket ticket = new Ticket(doc["Subject"].ToString(), doc["Description"].ToString(), (Status)Enum.Parse(typeof(Status), doc["Status"].ToString()), doc["Deadline"].ToInt32(), (IncidentType)Enum.Parse(typeof(IncidentType), doc["Incident Type"].ToString()));
                tickets.Add(ticket);
            }

            return tickets;
        }
    }
}
