using System;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

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

        //attribute is column value
        //collectionName is table
        //searchvalue is what you are looking for.

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
            var filter = Builders<BsonDocument>.Filter.Eq("firstName", SearchValue);
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }

        protected List<BsonDocument> GetSpecificDocumentsList(string CollectionName, string SearchValue, string Attribute)
        {
            var collection = database.GetCollection<BsonDocument>(CollectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(Attribute, SearchValue);
            var documents = collection.Find(filter).ToList();
            return documents;
        }

        protected BsonDocument SearchByString(string CollectionName, string SearchValue, string Attribute)
        {
            //attribute is column value
            //collectionName is table
            //searchvalue is what you are looking for.
            var collection = database.GetCollection<BsonDocument>(CollectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(Attribute, SearchValue);
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }
    }
}
