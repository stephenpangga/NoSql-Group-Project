﻿using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using NosqlModel;
using NosqlModel.Enums;

namespace NosqlDAL
{
    public class Users_DAO :Base
    {
        //use constructors
        public User GetUser(string Coll, int searchTerm)
        {
            User admin = new User();
            var document = GetDocumentByInt(Coll, searchTerm);

            admin.Email = document["email"].ToString();
            admin.FirstName = document["firstName"].ToString();

            return admin;
        }
        public User GetUser(string Coll, ObjectId searchTerm)
        {
            User admin = new User();
            var document = GetDocumentByInt(Coll, searchTerm);

            admin.Email = document["email"].ToString();
            admin.FirstName = document["firstName"].ToString();

            return admin;
        }
        //this method is just a useless working test(fornow)
        public User SearchUser(string Coll, string searchTerm)
        {
            User admin = new User();
            var document = SearchDocument(Coll, searchTerm);

            admin.Email = document["email"].ToString();
            admin.FirstName = document["firstName"].ToString();

            return admin;
        }

        //clean this later.
        public User SearchByEmail(string Email)
        {
            try
            {
                User admin = new User();
                var document = SearchByString("Users", Email, "email");

                admin.id = document["_id"].AsObjectId;
                admin.userId = document["userId"].ToInt32();
                admin.Email = document["email"].ToString();
                admin.Password = document["password"].ToString();
                admin.FirstName = document["firstName"].ToString();
                admin.LastName = document["lastName"].ToString();
                admin.roles = (Roles)Enum.Parse(typeof(Roles), document["role"].ToString());

                return admin;
            }
            catch
            {
                return null;
            }
        }

    }
}
