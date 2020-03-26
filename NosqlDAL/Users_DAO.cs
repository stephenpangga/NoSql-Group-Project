﻿using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;

namespace NosqlDAL
{
    public class Users_DAO :Base
    {
        //use constructors
        public User GetUser(string Coll, int searchTerm)
        {
            User admin = new User();
            var document = GetDocument(Coll, searchTerm);

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
    }
}
