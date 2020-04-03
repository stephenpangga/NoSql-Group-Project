using System;
using System.Collections.Generic;
using System.Text;

namespace NosqlModel
{
    public class IncidentType
    {

        public static readonly IncidentType PC = new IncidentType(MainType.Hardware, 1, "PC/laptop");
        public static readonly IncidentType Mobile = new IncidentType(MainType.Hardware, 2, "Mobile device");
        public static readonly IncidentType Hardware = new IncidentType(MainType.Hardware, 3, "Other");
        public static readonly IncidentType Login = new IncidentType(MainType.Software, 4, "Issue on login");
        public static readonly IncidentType Startup = new IncidentType(MainType.Software, 5, "Issue on startup");
        public static readonly IncidentType Feature = new IncidentType(MainType.Software, 6, "Problem with specific action/feature");
        public static readonly IncidentType Account = new IncidentType(MainType.Software, 7, "Problem with account permissions/authorizations");
        public static readonly IncidentType Network = new IncidentType(MainType.Software, 8, "Network issue");
        public static readonly IncidentType Software = new IncidentType(MainType.Software, 9, "Other");
        public static readonly IncidentType Payment = new IncidentType(MainType.Service, 10, "Payment issue");
        public static readonly IncidentType Service = new IncidentType(MainType.Service, 11, "Other");

        //used for searching subtypes
        public static readonly List<IncidentType> categories = new List<IncidentType>()
        {
            PC,Mobile,Hardware,Login,Startup,Feature,Account,Network,Software,Payment,Service
        };

        // used for getting maintypes
        public enum MainType
        {
            Hardware, Software, Service
        }

        public MainType Main { get; private set; }
        public short Index { get; private set; }
        public string Sub { get; private set; }

        private IncidentType(MainType main, short index, string sub)
        {
            Main = main;
            Index = index;
            Sub = sub;
        }

        //jesses code doesnt work, had to make separate constructor bc i am not responsible for his code
        public IncidentType(MainType mt)
        {
            this.Main = mt;
        }


    }
}
