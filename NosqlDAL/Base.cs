using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NosqlDAL
{
    class Base

    {
        private MongoClient dbClient;
        public void OpenConnection()
        {
            dbClient = new MongoClient("mongodb+srv://622022:MongoDB454%21@awesomecluster-7pybh.mongodb.net/test?retryWrites=true&w=majority");

        }

        public void GetCollection(string name)
        {
            //select db
            var db = dbClient.GetDatabase("NoSql");

            //Select collection
            var collection = db.GetCollection<BsonDocument>(name);
        }

        public void ExecuteQuery(string name)
        {
            OpenConnection();
            GetCollection(name);
        }
    }
}
