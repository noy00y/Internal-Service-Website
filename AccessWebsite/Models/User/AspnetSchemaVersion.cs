﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.User
{
    public partial class AspnetSchemaVersion
    {
        public string Feature { get; set; }
        public string CompatibleSchemaVersion { get; set; }
        public bool IsCurrentVersion { get; set; }
    }
}
