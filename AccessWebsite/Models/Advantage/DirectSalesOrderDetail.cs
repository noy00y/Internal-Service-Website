using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class DirectSalesOrderDetail
    {
        public int DirectSalesOrderDetailId { get; set; }
        public int DirectSalesOrderHeaderId { get; set; }
        public string UnitOfMeasureTypeCode { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string CompanyCode { get; set; }
        public string PriceListCode { get; set; }
        public string MultiplierTableCode { get; set; }
        public string ComputerizedPartNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductCrossReferenceCode { get; set; }
        public string ProductDescription { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? PricePer { get; set; }
        public decimal? ShipQuantity { get; set; }
        public decimal? BackorderQuantity { get; set; }
        public decimal? BackorderFactoryQuantity { get; set; }
        public decimal? ListPriceAmount { get; set; }
        public decimal? MultiplierAmount { get; set; }
        public decimal? NetPriceAmount { get; set; }
        public decimal? ExtendedPriceAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Clin { get; set; }

        public virtual DirectSalesOrderHeader DirectSalesOrderHeader { get; set; }
    }
}
