using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Webstart
{
    public partial class VwWebSession
    {
        public string AgentRecap { get; set; }
        public string Agent { get; set; }
        public string WebUser { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
        public int? SessionDuration { get; set; }
        public int SessionCount { get; set; }
    }
}
