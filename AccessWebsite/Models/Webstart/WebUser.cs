using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Webstart
{
    public partial class WebUser
    {
        public string WebUserCode { get; set; }
        public string WebUserFirstName { get; set; }
        public string WebUserLastName { get; set; }
        public string AgentCode { get; set; }
        public string CubeUsername { get; set; }
        public string CubePassword { get; set; }
    }
}
