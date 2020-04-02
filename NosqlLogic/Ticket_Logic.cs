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
            return Ticket_data.getTickets();
        }

        //ticket status
        public List<Ticket> getResolvedTickets()
        {
            return Ticket_data.getSpecificTickets("Resolved", "Status");
        }
        
        public List<Ticket> getUnResolvedTickets()
        {
            return Ticket_data.getSpecificTickets("Unresolved", "Status");
        }

        public List<Ticket> getInProcessTickets()
        {
            return Ticket_data.getSpecificTickets("InProcess", "Status");
        }
        //based on priority
        public List<Ticket> getUrgentTickets()
        {
            return Ticket_data.getSpecificTickets("High", "Priorty");
        }


    }
}
