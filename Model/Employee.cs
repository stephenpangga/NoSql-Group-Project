using System;

namespace Model
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }


        public Employee(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
    }
}
