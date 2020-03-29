using System;
using System.Collections.Generic;
using System.Text;
using NosqlModel;

namespace NosqlModel
{
    public class Incident
    {
        public int id;
        public DateTime reportDate;
        public string subject;
        public IncidentType incidentType;
        public User incidentUser;
        public PriorityType priority;
        public DateTime deadline;
        public string Description;

        public void SetDeadline(string text)
        {
            foreach (DeadlineType deadline in DeadlineType.deadlines)
            {
                if (deadline.Text == text)
                {
                    this.deadline = DeadlineType.SetDeadline(reportDate, deadline.Time);
                }
            }
        }

        
    }
}
