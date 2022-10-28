using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.User
{
    public partial class AspnetPersonalizationAllUser
    {
        public Guid PathId { get; set; }
        public byte[] PageSettings { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public virtual AspnetPath Path { get; set; }
    }
}
