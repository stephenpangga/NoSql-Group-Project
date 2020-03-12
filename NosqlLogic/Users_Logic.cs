using System;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlDAL;
using NosqlModel;

namespace NosqlLogic
{
    public class Users_Logic
    {
        
        Users_DAO Users_data = new Users_DAO();

        public User getSpecificUser(string collectionName, int SearchTerm)
        {
            return Users_data.GetUser(collectionName, SearchTerm);
        }

        public User SearchUser(string collectionName, string SearchTerm)
        {
            return Users_data.SearchUser(collectionName, SearchTerm);
        }
    }
}
