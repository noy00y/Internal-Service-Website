using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class Website_AdvantageContext : DbContext
    {
        public Website_AdvantageContext()
        {
        }

        public Website_AdvantageContext(DbContextOptions<Website_AdvantageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DirectSalesOrderDetail> DirectSalesOrderDetails { get; set; }
        public virtual DbSet<DirectSalesOrderHeader> DirectSalesOrderHeaders { get; set; }
        public virtual DbSet<DirectSalesOrderStatus> DirectSalesOrderStatuses { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<PriceDisc> PriceDiscs { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCompanyPriceClassCode> ProductCompanyPriceClassCodes { get; set; }
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }
        public virtual DbSet<ProductPriceDetail> ProductPriceDetails { get; set; }
        public virtual DbSet<ProductPriceHistory> ProductPriceHistories { get; set; }
        public virtual DbSet<ProductReference> ProductReferences { get; set; }
        public virtual DbSet<ProductUnitOfMeasure> ProductUnitOfMeasures { get; set; }
        public virtual DbSet<UsersActivity> UsersActivities { get; set; }
        public virtual DbSet<VwCustomer> VwCustomers { get; set; }
        public virtual DbSet<VwDirectSalesAnalysis> VwDirectSalesAnalyses { get; set; }
        public virtual DbSet<VwTestview> VwTestviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SQL307\\SQL2012;Database=Website_Advantage;User Id = Webdevelop; Password = Ipex1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.CustomerCode });

                entity.ToTable("Customer", "Customer");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeFaxAttentionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeFaxJobSiteFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeFaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BellContractorFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BuyingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BuyingGroupMemberNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollectorCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionTerritoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeBillToCustomerCode)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeCustomerCode)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeCustomerCodeCustomerName)
                    .HasMaxLength(257)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeParentCustomerCode)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeReferenceCustomerCode)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.ConsolidateInvoiceFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCodeStateProvinceCodeCityName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreditContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditContactPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditHoldCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimitAmount).HasColumnType("money");

                entity.Property(e => e.CreditReviewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreditUsedAmount).HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerComment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup1Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup2Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup3Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerInvoiceCopyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLocationCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNameCompanyCodeCustomerCode)
                    .HasMaxLength(154)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatusCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTradingPartnerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DunningLetterFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDataInterchangeCriticalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDataInterchangePartnerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDataInterchangePartnerShipToCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreightOnBoardCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsServicesTaxExemptFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HiddenCashDiscountPercent).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.InHouseCustomerFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAdditionalCopyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceFaxAttentionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFaxDeferTime)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFaxFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNotMailFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNotPrintFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MultipleLevelTaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NetPriceCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NextSystemSequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBuyingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OldCustomerGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductReferenceGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProvincialSalesTaxLicenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RemittanceAddressBuyingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReportGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDistrictCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPaymentTermCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReferenceCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRegionCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRepCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTerritoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceComment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceContactPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceWarehouseCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceZoneCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingWarehouseCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StandingOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatementFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExemptNumber)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ThirdPartyCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyInvoiceCopyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitedStatesFederalIdentificationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueAddedTaxClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPostalCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DirectSalesOrderDetail>(entity =>
            {
                entity.ToTable("DirectSalesOrderDetail");

                entity.Property(e => e.DirectSalesOrderDetailId).HasColumnName("DirectSalesOrderDetailID");

                entity.Property(e => e.BackorderFactoryQuantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.BackorderQuantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Clin)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLIN");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.DirectSalesOrderHeaderId).HasColumnName("DirectSalesOrderHeaderID");

                entity.Property(e => e.ExtendedPriceAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.ListPriceAmount).HasColumnType("numeric(9, 3)");

                entity.Property(e => e.MultiplierAmount).HasColumnType("numeric(9, 4)");

                entity.Property(e => e.MultiplierTableCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NetPriceAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PricePer).HasColumnType("numeric(9, 0)");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCrossReferenceCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipQuantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UnitLength).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UnitOfMeasureCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.DirectSalesOrderHeader)
                    .WithMany(p => p.DirectSalesOrderDetails)
                    .HasForeignKey(d => d.DirectSalesOrderHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DirectSalesOrderDetail_DirectSalesOrderHeader");
            });

            modelBuilder.Entity<DirectSalesOrderHeader>(entity =>
            {
                entity.ToTable("DirectSalesOrderHeader");

                entity.Property(e => e.DirectSalesOrderHeaderId).HasColumnName("DirectSalesOrderHeaderID");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressZip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.FreightEstimateAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.FreightTermCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MultiplierTableCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NetPriceListCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayTermCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCrossReferenceGroupCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RegionalPriceListCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressZip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToTelephoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipViaCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WaybillNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DirectSalesOrderStatus>(entity =>
            {
                entity.HasKey(e => e.DirectSalesOrderStatusCode);

                entity.ToTable("DirectSalesOrderStatus");

                entity.Property(e => e.DirectSalesOrderStatusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DirectSalesOrderStatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.NewsDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NewsHeader)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NewsText)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PriceDisc>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.PriceListCode, e.GenericCode, e.MultiplierCode });

                entity.ToTable("PriceDisc", "PriceDisc");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenericCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MultiplierCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Multiplier).HasColumnType("decimal(9, 4)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ComputerizedPartNumber);

                entity.ToTable("Product", "Product");

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountingStatusCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AddedWeight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AddedWeightDifferencePercent).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.AffiliatedPurchaseFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateUniversalProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AngleAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ApplicationAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AssemblyAllocationCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute39Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute40Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute41Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute42Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute43Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute44Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Attribute45Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeCatalogNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeDuplicateReasonCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeGroupingCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeOriginalEquipmentManufacturerProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeStatusCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AverageCostAmount).HasColumnType("money");

                entity.Property(e => e.BackOrderQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.BellLength).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.BillOfMaterialLowestLevelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandIpexattributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BrandIPEXAttributeCode");

                entity.Property(e => e.BrandIpexusattributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BrandIPEXUSAttributeCode");

                entity.Property(e => e.BrandMultiAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CalculatedAddedWeight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CalculatedWeight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.CertificationAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClassAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ColorAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentOptionAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigurationCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionTypeAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumableRepairCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContractFirmWeek).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ConversionTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CostErrorFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CubeSpace).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.CuttOffDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DangerousGoodCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultRoutingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DesiredInventoryStockDay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Diameter1AttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter2AttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter3AttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter4AttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DiameterAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension2Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension3Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension4Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DimensionalStandardAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DockToStockLeadTimeDay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.DrawingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DrawingSize).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.DrawingTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EconomicOrderQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.EngineeringRevisionEffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EngineeringRevisionEnginerringChangeOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineeringRevisionLevelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineeringRevisionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstimateCostCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExcessReasonCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExcludeWeightInAssemblyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExtraCommissionGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FeatureAattributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FeatureAAttributeCode");

                entity.Property(e => e.FeatureBattributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FeatureBAttributeCode");

                entity.Property(e => e.FeaturesAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FirstComponentComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstPartComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstRoutingRecordSequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstSequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormerProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GeneralLedgerGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GlobeColorAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GlobeMaterialAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GroupTechnologyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InspectionRequiredFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ItemClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastActivityDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastCycleCountDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastCycleCountQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LastNoShipDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastRoutingRecordSequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastSequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastYearUsageQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.LengthAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LengthToAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LevelMachineAmount).HasColumnType("money");

                entity.Property(e => e.LevelMachineHour).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.LevelSetupAmount).HasColumnType("money");

                entity.Property(e => e.LevelSetupHour).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ManufacturingAllocationQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ManufacturingLeadTimeDay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ManufacturingRevisionEffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ManufacturingRevisionEngineeringChangeOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturingRevisionLevelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialReviewBoardQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MatrixCategoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaximumOrderQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MaximumStockQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MinimumOrderQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MinimumStockQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MonthToDateUsageQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MountTypeAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MoveQueueTimeHour).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.MultipleOrderQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NextReceiptDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NextReceiptQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.NonReturnableCancellableFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NonStockInventoryQuoteNumberLineNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OnHandQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OneLevelWeight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OptionsAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPeriodDay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.OriginCountryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OuterDiameter).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.PackageQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PackagingLockedSwitchFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumberAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PlannerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PriceClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryManufacturingWarehouseCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductAbbreviation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCodeProductName)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProductLineCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductNameProductCode)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ProductRequestReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingLeadTimeDay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.PurchasingUnitOfMeasureCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PurchasingUnitOfMeasureConversionRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.QualityControlCategoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.QualityReferencenNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QuarantineQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RadiusAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingInInspectionQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReorderQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RollUpWeight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RoyaltyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RunTimeHour).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.SafetyStockQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ScrapPercent).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.SealMaterialAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SeriesAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetupTimeHour).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShelfLifeDay).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.ShippingAllocationQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ShrinkFactorPercent).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.SiteTrackFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SizeAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SortNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificGravity).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.StandardLaborCostAmount).HasColumnType("money");

                entity.Property(e => e.StandardUnitOfMeasureTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubstituteProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SupersedesProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TariffCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TemporaryComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThicknessAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TorqueAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitStructureFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UniversalProductCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UseAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VoltageSignalAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.WarehousePlantFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.WattAttributeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.WeightDifferencePercent).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.WeightFactorRate).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.WeightUpdateFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCompanyPriceClassCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductCompanyPriceClassCode", "Product");

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyPriceClassCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerizedPartNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ComputerizedPartNumberNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ComputerizedPartNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductCompanyPriceClassCode_Product");
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.HasKey(e => new { e.ComputerizedPartNumber, e.UnitOfMeasureTypeCode, e.LanguageCode });

                entity.ToTable("ProductDescription", "Product");

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.ComputerizedPartNumberNavigation)
                    .WithMany(p => p.ProductDescriptions)
                    .HasForeignKey(d => d.ComputerizedPartNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductDescription_Product");
            });

            modelBuilder.Entity<ProductPriceDetail>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.PriceListCode, e.ComputerizedPartNumber });

                entity.ToTable("ProductPriceDetail", "ProductPrice");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodePriceListCodeComputerizedPartNumber)
                    .IsRequired()
                    .HasMaxLength(102)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentEffectiveDate).HasColumnType("date");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductPriceHistory>(entity =>
            {
                entity.HasKey(e => new { e.CompanyCode, e.PriceListCode, e.ComputerizedPartNumber, e.CurrentEffectiveDate });

                entity.ToTable("ProductPriceHistory", "ProductPrice");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentEffectiveDate).HasColumnType("date");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<ProductReference>(entity =>
            {
                entity.HasKey(e => new { e.ProductReferenceGroupCode, e.ProductReferenceCode });

                entity.ToTable("ProductReference", "ProductReference");

                entity.Property(e => e.ProductReferenceGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductReferenceCode)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .UseCollation("SQL_Latin1_General_CP1_CS_AS");

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLabelName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerUnitQuantity).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.ProductReferenceTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitQuantity).HasColumnType("decimal(19, 4)");
            });

            modelBuilder.Entity<ProductUnitOfMeasure>(entity =>
            {
                entity.HasKey(e => new { e.ComputerizedPartNumber, e.UnitOfMeasureTypeCode })
                    .HasName("PK__ProductU__361287BE44CA3770");

                entity.ToTable("ProductUnitOfMeasure", "Product");

                entity.Property(e => e.ComputerizedPartNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitLength).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.UnitPriceAmount).HasColumnType("money");
            });

            modelBuilder.Entity<UsersActivity>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UsersActivity");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.DirectSalesOrderHeaderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DirectSalesOrderHeaderID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReleaseNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WaybillNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Customer");

                entity.Property(e => e.ActiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeFaxAttentionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeFaxJobSiteFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AdvancedShipmentNoticeFaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BellContractorFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BuyingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BuyingGroupMemberNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CityName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CollectorCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionTerritoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeBillToCustomerCode)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeCustomerCode)
                    .IsRequired()
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeCustomerCodeCustomerName)
                    .HasMaxLength(257)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeParentCustomerCode)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCodeReferenceCustomerCode)
                    .HasMaxLength(51)
                    .IsUnicode(false);

                entity.Property(e => e.ConsolidateInvoiceFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCodeStateProvinceCodeCityName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreditContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditContactPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditHoldCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreditLimitAmount).HasColumnType("money");

                entity.Property(e => e.CreditReviewDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreditUsedAmount).HasColumnType("money");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerComment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup1Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup2Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroup3Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerInvoiceCopyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerLocationCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNameCompanyCodeCustomerCode)
                    .HasMaxLength(154)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerStatusCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTradingPartnerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DunningLetterFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDataInterchangeCriticalFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDataInterchangePartnerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicDataInterchangePartnerShipToCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FreightOnBoardCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GlobalContractNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoodsServicesTaxExemptFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HiddenCashDiscountPercent).HasColumnType("decimal(9, 4)");

                entity.Property(e => e.InHouseCustomerFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceAdditionalCopyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceFaxAttentionName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFaxDeferTime)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFaxFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceFaxNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNotMailFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNotPrintFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MultipleLevelTaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NetPriceCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NextSystemSequenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldBuyingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OldCustomerGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ParentCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PriceClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PriceListCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProductReferenceGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProvincialSalesTaxLicenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RemittanceAddressBuyingGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReportGroupCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesDistrictCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesPaymentTermCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesReferenceCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRegionCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRepCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTerritoryCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceComment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceContactPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceWarehouseCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceZoneCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingWarehouseCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StandingOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StatementFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatusFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExemptNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ThirdPartyCustomerCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyInvoiceCopyFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UnitedStatesFederalIdentificationNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueAddedTaxClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZipPostalCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwDirectSalesAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DirectSalesAnalysis");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DirectSalesOrderHeaderId).HasColumnName("DirectSalesOrderHeaderID");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("numeric(38, 2)")
                    .HasColumnName("TotalAmount$");
            });

            modelBuilder.Entity<VwTestview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_testview");

                entity.Property(e => e.AgentCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerAddressZip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPurchaseOrderNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DateUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.DirectSalesOrderHeaderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DirectSalesOrderHeaderID");

                entity.Property(e => e.FreightEstimateAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.FreightTermCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MultiplierTableCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NetPriceListCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PayTermCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCrossReferenceGroupCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RegionalPriceListCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerAddressZip)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFaxNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToTelephoneNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipViaCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureTypeCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WaybillNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
