using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel.Enums;

namespace NosqlModel
{
    public class Ticket
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public int Deadline { get; set; }
        public NosqlModel.Enums.IncidentType IncidentType { get; set; }

        public Ticket(string Subject, string Description, Status Status, int Deadline, NosqlModel.Enums.IncidentType IncidentType)
        {
            this.Subject = Subject;
            this.Description = Description;
            this.Status = Status;
            this.Deadline = Deadline;
            this.IncidentType = IncidentType;
        }
    }
}
