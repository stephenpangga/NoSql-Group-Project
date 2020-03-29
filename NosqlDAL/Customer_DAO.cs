using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlModel.Enums;


namespace NosqlDAL
{
    public class Customer_DAO : Base
    {
        public List<Ticket> GetTicketsForCustomer(string Coll, string searchTerm, string attribute)
        {
            var documents = GetSpecificDocumentsList(Coll, searchTerm, attribute);

            List<Ticket> tickets = new List<Ticket>();

            foreach(var doc in documents)
            {
                Ticket ticket = new Ticket(doc["Subject"].ToString(), doc["Description"].ToString(), (Status)Enum.Parse(typeof(Status), doc["Status"].ToString()), doc["Deadline"].ToInt32(), (NosqlModel.IncidentType)Enum.Parse(typeof(NosqlModel.IncidentType), doc["Incidenttype"].ToString()));
                tickets.Add(ticket);
            }

            return tickets;
        }

        public bool UpdateCustomerInfo(string collectionName, string searchValue, string attribute, string updateValue, string column)
        {
            var result = UpdateDocument(collectionName, searchValue, attribute, updateValue, column);
            return result;
            
        }
    }
}
