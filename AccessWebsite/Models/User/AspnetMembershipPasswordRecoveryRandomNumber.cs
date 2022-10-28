using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.User
{
    public partial class AspnetMembershipPasswordRecoveryRandomNumber
    {
        public string UserName { get; set; }
        public int? PasswordRecoveryRandomNumb { get; set; }
    }
}
