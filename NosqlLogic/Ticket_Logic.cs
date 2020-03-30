using System;
using System.Collections.Generic;
using System.Text;
using NosqlDAL;
using NosqlModel;

namespace NosqlLogic
{
    class Ticket_Logic
    {
        //might need to make a seperate ticket dao. to avoid issues.
        Incident_DAO Ticket_data = new Incident_DAO();

        public List<Ticket> getTickets()
        {
            return Ticket_data.GetTickets();
        }
    }
}
