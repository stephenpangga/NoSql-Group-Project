using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;

namespace NosqlDAL
{
    class Incident_DAO
    {
        public List<Incident> GetIncidents(string Coll, int searchTerm)
        {
            List<Incident> incidents = new List<Incident>();
            return incidents;
        }


        public void CreateIncident(string Coll, string searchTerm)
        {
           
        }

        //clean this later.
        public Incident SearchByEmail(string Email)
        {
            try
            {
                Incident incident = new Incident();
                //var document = SearchByString("Incident", Email, "email");

                //admin.Email = document["email"].ToString();
                //admin.FirstName = document["firstName"].ToString();
                //admin.Password = document["password"].ToString();

                return incident;
            }
            catch
            {
                return null;
            }
        }
    }
}
