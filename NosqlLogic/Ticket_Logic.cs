using System;
using System.Collections.Generic;
using System.Text;
using NosqlDAL;
using NosqlModel;

namespace NosqlLogic
{
    public class Ticket_Logic
    {
        //might need to make a seperate ticket dao. to avoid issues.
        Ticket_DAO Ticket_data = new Ticket_DAO();

        public List<Ticket> getTickets()
        {
            return Ticket_data.GetTickets();
        }
    }
}
