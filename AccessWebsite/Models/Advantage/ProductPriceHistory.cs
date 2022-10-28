﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class ProductPriceHistory
    {
        public string CompanyCode { get; set; }
        public string PriceListCode { get; set; }
        public string ComputerizedPartNumber { get; set; }
        public DateTime CurrentEffectiveDate { get; set; }
        public decimal? CurrentPrice { get; set; }
    }
}
