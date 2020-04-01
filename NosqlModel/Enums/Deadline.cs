using System;
using System.Collections.Generic;
using System.Text;

namespace NosqlModel
{
    public class DeadlineType
    {
        public static readonly DeadlineType W1 = new DeadlineType("7 days", new TimeSpan(7,0,0,0));
        public static readonly DeadlineType W2 = new DeadlineType("14 days", new TimeSpan(14, 0, 0, 0));
        public static readonly DeadlineType W4 = new DeadlineType("28 days", new TimeSpan(28, 0, 0, 0));
        public static readonly DeadlineType M6 = new DeadlineType("6 months", new TimeSpan(180, 0, 0, 0));

        public static readonly List<DeadlineType> deadlines = new List<DeadlineType>()
        {
            W1,W2,W4,M6
        };

        public String Text { get; private set; }
        public TimeSpan Time { get; private set; }

        private DeadlineType(string text, TimeSpan time)
        {
            Text = text;
            Time = time;
        }

        public static DateTime SetDeadline(DateTime reportDate,TimeSpan ts)
        {
            if (ts.Days == 7)
            {
                return reportDate.AddDays(7);
            }
            else if (ts.Days == 14)
            {
                return reportDate.AddDays(14);
            }
            else if (ts.Days == 28)
            {
                return reportDate.AddDays(28);
            }
            else if (ts.Days == 180)
            {
                return reportDate.AddMonths(6);
            }
            return reportDate;
        }

    }


}
