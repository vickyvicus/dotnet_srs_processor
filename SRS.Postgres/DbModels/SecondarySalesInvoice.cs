using Library.CommonEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.DbModels
{
    [Table("SecondarySalesInvoice")]
    public class SecondarySalesInvoice
    {
        [Key]
        public long Id { get; set; }
        public long CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string InvoiceNo { get; set; }
        public string ErpInvoiceNo { get; set; }
        public string ErpSoNo { get; set; }
        public long TimeStamp { get; set; }
        public string BuyerFirmName { get; set; }
        public string BuyerType { get; set; }
        public string SellerFirmName { get; set; }
        public string SellerType { get; set; }
        public long BuyerId { get; set; }
        public string BuyerBillingAddress { get; set; }
        public decimal? TotalCases { get; set; }
        public decimal? TotalPieces { get; set; }
        public decimal? TotalValue { get; set; }
        public decimal? TotalGrossValue { get; set; }
        public decimal? TotalDiscount { get; set; }
        public decimal? TotalNetValue { get; set; }
        //public Guid RequestGuid { get; set; }c
        public string Beat { get; set; }
        public string ESMName { get; set; }
        public string OutletName { get; set; }
        public decimal TotalValueWithTcs { get; set; }
        public long SellerId { get; set; }
        public bool IsValid { get; set; }
        public bool IsCompleteInvoice { get; set; }
        public DateTime? SoDate { get; set; }
        public Guid RequestId { get; set; }
        public decimal? TotalCGST { get; set; }
        public decimal? TotalIGST { get; set; }
        public decimal? TotalSGST { get; set; }
        public decimal? TotalUTGST { get; set; }
        public decimal? TotalCESS { get; set; }
        public decimal? TotalGST { get; set; }
        public string SellerPhoneNumber { get; set; }
        public string SellerState { get; set; }
        public string SellerAddress { get; set; }
        public string SellerPinCode { get; set; }
        public string SellerGstINNumber { get; set; }
        public string SellerPanNumber { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public string BuyerZone { get; set; }
        public string BuyerErpId { get; set; }
        public string SellerErpId { get; set; }
        public long? BuyerZoneId { get; set; }
        public long? BuyerRegionId { get; set; }
        public string BuyerRegion { get; set; }
        public string BuyerState { get; set; }
        public int BuyerShippingAddressId { get; set; }
        public int BuyerBillingAddressId { get; set; }
        public string BuyerShippingAddress { get; set; }
        public string BuyerGSTIN { get; set; }
        public string BuyerPanNumber { get; set; }
        public string BuyerFssaiNumber { get; set; }
        public string BuyerCity { get; set; }
        public string BuyerPinCode { get; set; }
        public string SellerFssaiNumber { get; set; }
        public string SellerCity { get; set; }
        public string SellerBankName { get; set; }
        public string SellerAccountNumber { get; set; }
        public string SellerIFSCCode { get; set; }
        public string SoCode { get; set; }
        public string Reason { get; set; }

        public string SellerRegion { get; set; }
        public string SellerZone { get; set; }
        public string SellerTerritory { get; set; }
        public string BuyerTerritory { get; set; }
        public long? SellerRegionId { get; set; }
        public long? SellerStockistType { get; set; }
        public long? SellerUserRole { get; set; }
        public long? BuyerStockistType { get; set; }
        public long? BuyerUserRole { get; set; }
        public long? BuyerBeatId { get; set; }
        public string BuyerBeatname { get; set; }
        public bool IsGRDone { get; set; }

        //public string BeatErpId { get; set; }
        //public decimal? TotalQuantity { get; set; }
        public bool IsIDTBuyer { get; set; }
        //public Guid RequestGuid { get; set; }
        public decimal? TCSPercent { get; set; }
        public decimal? TCSValue { get; set; }
        public decimal? CollectionRemainingAmount { get; set; }
        public decimal? SalesOrderTotalValue { get; set; }
        public decimal? PrimaryDiscountValue { get; set; }
        public decimal? SecondaryDiscountValue { get; set; }
        public decimal? CashDiscountValue { get; set; }
        public SIOrderSource OrderSource { get; set; }
        public SIEditStatus EditStatus { get; set; }
        public SIInvoiceType InvoiceType { get; set; }
        public SIOrderStatus Status { get; set; }
        public string IrnNo { get; set; }
        public string AckNo { get; set; }
        public DateTime? AckDate { get; set; }
        public string EwbNo { get; set; }
        public DateTime? EwbDate { get; set; }
        public DateTime? EwbValidTill { get; set; }
        public string SignedInvoice { get; set; }
        public string SignedQRCode { get; set; }
        public string EInvoiceQRURL { get; set; }
        //[NotMapped]
        public string EInvoiceURL { get; set; }
        public string EwayURL { get; set; }
        //[NotMapped]
        public DateTime? CancelIRNDate { get; set; }
        public DateTime? CancelEWBDate { get; set; }
        //[NotMapped]
        public bool IsEWBGenrated { get; set; }
        public bool IsEWBCancelled { get; set; }
        //[NotMapped]
        public bool IsEInvoiceGenrated { get; set; }
        //[NotMapped]
        public long? EwbDistance { get; set; }

        public long? VehicleId { get; set; }
        public string VehicleType { get; set; }
        public long? TransportMode { get; set; }
        public string InvoiceHash { get; set; }

        public string WarehouseErpId { get; set; }

        public List<SecondarySalesInvoiceItems> Items { get; set; }
    }

    [Table("SecondarySalesInvoiceItems")]
    public class SecondarySalesInvoiceItems
    {
        [Key]
        public long Id { get; set; }

        public long DistributorId { get; set; }
        public long ProductId { get; set; }
        public string ProductERPId { get; set; }
        public decimal Price { get; set; }
        public decimal MRP { get; set; }
        public decimal Quantity { get; set; }
        public long PendingQty { get; set; }
        public long InvoicedQuantity { get; set; }
        public string BatchNo { get; set; }
        public decimal TotalWithTcs { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal PrimaryDiscountPercent { get; set; }
        public decimal PrimaryDiscountValue { get; set; }
        public decimal SecondaryDiscountPercent { get; set; }
        public decimal SecondaryDiscountValue { get; set; }
        public string PrimarySchemeId { get; set; }
        public string SecondarySchemeId { get; set; }
        public string PrimarySchemeSlabId { get; set; }
        public string SecondarySchemeSlabId { get; set; }
        public decimal TotalValue { get; set; }
        public decimal NetValue { get; set; }
        public decimal GrossValue { get; set; }
        public string Name { get; set; }
        public long SecondayCategoryId { get; set; }
        public string SecondayCategory { get; set; }
        public long PrimaryCategoryId { get; set; }
        public string PrimaryCategory { get; set; }
        public long ProductDivisionId { get; set; }
        public string ProductDivision { get; set; }
        public decimal CashDiscountPercent { get; set; }
        public decimal CashDiscountValue { get; set; }
        public decimal TradeDiscountPercent { get; set; }
        public decimal TradeDiscountValue { get; set; }
        public decimal FOCPercent { get; set; }
        public decimal FOCValue { get; set; }
        public decimal FreeQty { get; set; }
        public decimal TCSValue { get; set; }
        public decimal CGSTValue { get; set; }
        public decimal SGSTValue { get; set; }
        public decimal IGSTValue { get; set; }
        public decimal StandardUnitConversionFactor { get; set; }
        public string Unit { get; set; }

        //[NotMapped]
        public decimal TotalMargin { get; set; }

        public decimal GstValue { get; set; }
        public decimal GstPercent { get; set; }
        public decimal VATPercentage { get; set; }
        public decimal VATValue { get; set; }
        public SecondarySalesInvoice SecondarySalesInvoice { get; set; }
    }
}
