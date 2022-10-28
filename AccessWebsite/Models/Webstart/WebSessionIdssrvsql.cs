using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Webstart
{
    public partial class WebSessionIdssrvsql
    {
        public string WebSessionId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string WebUserCode { get; set; }
        public decimal? SessionDuration { get; set; }
        public int SessionCount { get; set; }
        public string StartDate { get; set; }
        public string StartTime { get; set; }
        public string EndDate { get; set; }
        public string EndTime { get; set; }
    }
}
