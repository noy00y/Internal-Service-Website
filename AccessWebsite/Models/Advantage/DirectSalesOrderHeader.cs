using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class DirectSalesOrderHeader
    {
        public DirectSalesOrderHeader()
        {
            DirectSalesOrderDetails = new HashSet<DirectSalesOrderDetail>();
        }

        public int DirectSalesOrderHeaderId { get; set; }
        public string Username { get; set; }
        public string StatusCode { get; set; }
        public string CompanyCode { get; set; }
        public string AgentCode { get; set; }
        public string ShipToCustomerCode { get; set; }
        public string ShipToCustomerName { get; set; }
        public string ShipToCustomerAddressLine1 { get; set; }
        public string ShipToCustomerAddressLine2 { get; set; }
        public string ShipToCustomerAddressCity { get; set; }
        public string ShipToCustomerAddressState { get; set; }
        public string ShipToCustomerAddressZip { get; set; }
        public string ShipToTelephoneNumber { get; set; }
        public string ShipToFaxNumber { get; set; }
        public string BillToCustomerCode { get; set; }
        public string BillToCustomerName { get; set; }
        public string BillToCustomerAddressLine1 { get; set; }
        public string BillToCustomerAddressLine2 { get; set; }
        public string BillToCustomerAddressCity { get; set; }
        public string BillToCustomerAddressState { get; set; }
        public string BillToCustomerAddressZip { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string WarehouseCode { get; set; }
        public string ReleaseNumber { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public DateTime? PurchaseOrderDate { get; set; }
        public string ShipViaCode { get; set; }
        public string WaybillNumber { get; set; }
        public string ProductCrossReferenceGroupCode { get; set; }
        public string UnitOfMeasureTypeCode { get; set; }
        public string PayTermCode { get; set; }
        public string CurrencyCode { get; set; }
        public string RegionalPriceListCode { get; set; }
        public string NetPriceListCode { get; set; }
        public string MultiplierTableCode { get; set; }
        public string FreightTermCode { get; set; }
        public decimal? FreightEstimateAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<DirectSalesOrderDetail> DirectSalesOrderDetails { get; set; }
    }
}
