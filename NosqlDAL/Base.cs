using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NosqlDAL
{
    public abstract class Base
    {
        private MongoClient MongoClient;
        private IMongoDatabase database;

        public Base()
        {
            MongoClient = new MongoClient("mongodb+srv://622022:MongoDB454%21@awesomecluster-7pybh.mongodb.net/test?retryWrites=true&w=majority");
            database = MongoClient.GetDatabase("NoSql");

        }

        //example for selecting a certain document from a collection by INT
        protected BsonDocument GetDocument(string CollectionName, int SearchValue)
        {
            var collection = database.GetCollection<BsonDocument>(CollectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("userId", SearchValue);
            var Document = collection.Find(filter).FirstOrDefault();
            return Document;
        }

        protected BsonDocument SearchDocument(string CollectionName, string SearchValue)
        {
            var collection = database.GetCollection<BsonDocument>(CollectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("firstName", "admin");
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }
    }
}
