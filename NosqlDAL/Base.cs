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

        protected readonly string TicketColl = "Tickets";
        protected readonly string IncidentColl = "Incidents";
        protected readonly string UserColl = "Users";

        public Base()
        {
            MongoClient = new MongoClient("mongodb+srv://622022:MongoDB454%21@awesomecluster-7pybh.mongodb.net/test?retryWrites=true&w=majority");
            database = MongoClient.GetDatabase("NoSql");
        }

        //example for selecting a certain document from a collection by INT
        protected BsonDocument GetDocumentByInt(string collectionName, int searchValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("userId", searchValue);
            var Document = collection.Find(filter).FirstOrDefault();
            return Document;
        }
        protected BsonDocument GetDocumentByInt(string collectionName, ObjectId searchValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", searchValue);
            var Document = collection.Find(filter).FirstOrDefault();
            return Document;
        }
        //Tim - Insert a new user into the database / cluster
        public void InsertUser(int id, string mail, string password, string firstName, string lastName, string role) 
        {
            BsonDocument document = new BsonDocument();
            document["userId"] = id;
            document["email"] = mail;
            document["password"] = password;
            document["firstName"] = firstName;
            document["lastName"] = lastName;
            document["role"] = role;

            var collection = database.GetCollection<BsonDocument>("Users");
            collection.InsertOne(document);
        }

        //Tim - delete data from the database
        public void deleteData(int variable, string searchterm, string collectionName) 
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(searchterm, variable);
            collection.DeleteOne(deleteFilter);
        }
        public void deleteData(ObjectId variable, string searchterm, string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var deleteFilter = Builders<BsonDocument>.Filter.Eq(searchterm, variable);
            collection.DeleteOne(deleteFilter);
        }

        protected BsonDocument SearchDocument(string collectionName, string searchValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("firstName", searchValue);
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }

        //get by object id
        protected List<BsonDocument> GetSpecificDocumentsList(string collectionName, ObjectId searchValue, string attribute)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);
            var documents = collection.Find(filter).ToList();
            return documents;
        }

        //get by string
        protected List<BsonDocument> GetSpecificDocumentList(string collectionName, string searchValue, string attribute)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);
            var documents = collection.Find(filter).ToList();
            return documents;
        }

        protected BsonDocument SearchByString(string collectionName, string searchValue, string attribute)
        {
            //used for looking at user specific accounts at the db
            //attribute is column value
            //collectionName is table
            //searchvalue is what you are looking for.
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);
            var firstDocument = collection.Find(filter).FirstOrDefault();
            return firstDocument;
        }
        //get all method from the database.maybe a general one?
        protected List<BsonDocument> GetAll(string collectionName)
        {
            //using this to get all tickets -stephen
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Empty;
            var Document = collection.Find(filter).ToList();
            return Document;
        }

        //attribute is the column for selecting doc and column is used to select the column to be updated
        protected bool UpdateDocument(string collectionName, ObjectId searchValue, string attribute,string updateValue,string column)
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

        //Tim - just to update from my end. Making a serperate method is easier in this case.
        protected void UpdateUser(int id, string updateValue, string column)
        {
            //select which document to update
            var collection = database.GetCollection<BsonDocument>("Users");
            var filter = Builders<BsonDocument>.Filter.Eq("userId", id);

            //select what value to change in that document
            var update = Builders<BsonDocument>.Update.Set(column, updateValue);
            var result = collection.UpdateOne(filter, update);
        }

            protected bool UpdateDocumentbyString(string collectionName, string searchValue, string attribute, string updateValue, string column)
        {
            //select which document to update
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq(attribute, searchValue);

            //select what value to change in that document
            var update = Builders<BsonDocument>.Update.Set(column, updateValue);
            var result = collection.UpdateOne(filter, update);

            bool checkResult;

            if (result.MatchedCount == 1 && result.ModifiedCount == 1)
            {
                checkResult = true;
            }
            else
            {
                checkResult = false;
            }
            return checkResult;
        }

        protected void InsertOne(BsonDocument document, string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }
    }
}
