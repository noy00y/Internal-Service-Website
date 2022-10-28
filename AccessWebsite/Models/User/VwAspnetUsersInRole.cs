using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.User
{
    public partial class VwAspnetUsersInRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}
