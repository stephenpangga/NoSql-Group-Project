using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace NosqlDAL
{
    class Base
    {
        public static void OpenConnection()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://622022:MongoDB454%21@awesomecluster-7pybh.mongodb.net/test?retryWrites=true&w=majority");

        }

        //different methods for queries come here
    }
}
