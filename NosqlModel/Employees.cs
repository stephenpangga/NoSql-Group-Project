using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel.Enums;

namespace NosqlModel
{
    public class Employees
    {
        public int userID { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Roles role { get; set; }

        public Employees(int userID, string email, string password, string firstName, string lastName, Roles role)
        {
            this.userID = userID;
            this.email = email;
            this.password = password;
            this.lastName = lastName;
            this.firstName = firstName;
            this.role = role;
        }
    }
}
