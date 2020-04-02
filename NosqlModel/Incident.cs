using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using NosqlModel;
using NosqlModel.Enums;

namespace NosqlModel
{
    public class Incident
    {
        public ObjectId id;
        public DateTime reportDate;
        public string subject;
        public IncidentType incidentType;
        public User incidentUser;
        public PriorityTypes priority;
        public DateTime deadline;
        public string description;
        public Enums.Status status;

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
