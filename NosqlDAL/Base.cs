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
        protected BsonDocument GetDocumentByInt(string collectionName, int searchValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("userId", searchValue);
            var Document = collection.Find(filter).FirstOrDefault();
            return Document;
        }

        protected BsonDocument SearchDocument(string collectionName, string searchValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("firstName", searchValue);
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }

        protected List<BsonDocument> GetSpecificDocumentsList(string collectionName, string searchValue, string attribute)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);
            var documents = collection.Find(filter).ToList();
            return documents;
        }

        protected BsonDocument SearchByString(string collectionName, string searchValue, string attribute)
        {
            //attribute is column value
            //collectionName is table
            //searchvalue is what you are looking for.
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }

        //attribute is the column for selecting doc and column is used to select the column to be updated
        protected bool UpdateDocument(string collectionName, string searchValue, string attribute,string updateValue,string column)
        {
            //select which document to update
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);

            //select what value to change in that document
            var update = Builders<BsonDocument>.Update.Set(column, updateValue);
            var result =collection.UpdateOne(filter, update);

            bool checkResult;
            
            if(result.MatchedCount == 1 && result.ModifiedCount == 1)
            {
                checkResult = true;
            }
            else
            {
                checkResult = false;
            }
            return checkResult;
        }
    }
}
