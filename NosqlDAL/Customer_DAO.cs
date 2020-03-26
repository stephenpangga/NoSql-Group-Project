using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NosqlDAL
{
    class Customer_DAO : Base
    {
        public List<BsonDocument> GetTicketsForEmployee(string Coll, string searchTerm)
        {
            var documents = GetSpecificDocumentsList(Coll, searchTerm);

            return documents;
        }
    }
}
