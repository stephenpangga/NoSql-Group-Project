using System;
using MongoDB.Driver;
using MongoDB.Bson;
using NosqlModel.Enums;

namespace NosqlModel
{
    public class User
    {
        public ObjectId id;
        public int userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Roles roles;
        public string Password { get; set; }

        public User(){}

        public User(int userId, string email, string password, string firstName, string lastName, Roles role) 
        {
            this.userId = userId;
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.roles = role;
        }
    }
}
