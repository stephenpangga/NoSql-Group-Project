using System;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlModel.Enums;

namespace NosqlModel
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Roles roles;
        public string Password { get; set; }

    }
}
