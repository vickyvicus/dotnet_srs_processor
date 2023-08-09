using Library.CommonEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.DbModels
{
    public class PurchaseOrder
    {
        [Key]
        public long Id { get; set; }
        public Guid RequestGuid { get; set; }
        public long SellerId { get; set; }
        public long BuyerId { get; set; }
        public long CompanyId { get; set; }
        public decimal TotalNetValue { get; set; }
        public double TotalDiscount { get; set; }
        public double TotalGrossValue { get; set; }
        public double TotalPieces { get; set; }
        public double TotalCases { get; set; }
        public decimal TotalValue { get; set; }
        public double TotalGST { get; set; }
        public double TotalIGST { get; set; }
        public double TotalSGST { get; set; }
        public double TotalCGST { get; set; }
        public string PaymentTerms { get; set; }
        public bool IsValid { get; set; }
        public bool IsDeleted { get; set; }
        public double TotalUTGST { get; set; }
        public long FactoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime ValidityUpdatedAt { get; set; }
        public Guid RequestId { get; set; }
        public string POCode { get; set; }
        public POPaymentStatus? PaymentStatus { get; set; }
        public double? PrimaryDiscountValue { get; set; }
        public double? SecondaryDiscountValue { get; set; }
        public string OutletName { get; set; }
        public long? ApprovedBy { get; set; }
        public DateTimeOffset OrderDateTime { get; set; }
        public string SellerFirmName { get; set; }
        public string SellerState { get; set; }
        public string SellerPhoneNumber { get; set; }
        public string SellerPanNumber { get; set; }
        public string BuyerFirmName { get; set; }
        public string BuyerPhoneNumber { get; set; }
        public string BuyerState { get; set; }
        public string BuyerShippingAddress { get; set; }
        public string BuyerPanNumber { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public bool IsApproved { get; set; }
        public string SellerType { get; set; }
        public string BuyerType { get; set; }
        public string SellerGstINNumber { get; set; }
        public string SellerAddress { get; set; }
        public string BuyerRegion { get; set; }
        public string BuyerGSTIN { get; set; }
        public POOrderStatus Status { get; set; }
        public int BuyerShippingAddressId { get; set; }
        public int BuyerBillingAddressId { get; set; }
        public string BuyerBillingAddress { get; set; }
        public OrderType? OrderType { get; set; }
        public string SellerRegion { get; set; }
        public string SellerZone { get; set; }
        public string SellerTerritory { get; set; }
        public string BuyerZone { get; set; }
        public string BuyerTerritory { get; set; }
        public string SapErpId { get; set; }
        public long? BuyerRegionId { get; set; }
        public long? BuyerZoneId { get; set; }
        public double TotalQuantity { get; set; }
        public DateTime UpdatedAt { get; set; }
        public double? PrimaryDiscountPercent { get; set; }
        public double? SecondaryDiscountPercent { get; set; }
        public long? SellerRegionId { get; set; }
        public string SOCode { get; set; }
        public Guid EventId { get; set; }
        public POOrderSource OrderSource { get; set; }
        public string Beat { get; set; }
        public string ESMName { get; set; }
        public long? FAOrderId { get; set; }
        public long TimeStamp { get; set; }
        public List<PurchaseOrderItems> Items { get; set; }
    }
    public class PurchaseOrderItems
    {
        [Key]
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long PurchaseOrderId { get; set; }
        public string ProductDivision { get; set; }
        public string PrimaryCategory { get; set; }
        public string SecondayCategory { get; set; }
        public double TotalValue { get; set; }
        public double GstValue { get; set; }
        public double GstPercent { get; set; }
        public double NetValue { get; set; }
        public double GrossValue { get; set; }
        public double Pieces { get; set; }
        public double Cases { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public double IGSTValue { get; set; }
        public decimal? UnitWeight { get; set; }
        public string Unit { get; set; }
        public double StandardUnitConversionFactor { get; set; }
        public double MRP { get; set; }
        public long? HSNCode { get; set; }
        public double CGST { get; set; }
        public double SGST { get; set; }
        public double IGST { get; set; }
        public long? ProductDivisionId { get; set; }
        public long? PrimaryCategoryId { get; set; }
        public long? SecondayCategoryId { get; set; }
        public long? DistributorId { get; set; }
        public double UTGST { get; set; }
        public long FactoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double CGSTValue { get; set; }
        public double SGSTValue { get; set; }
        public double UTGSTValue { get; set; }
        public bool IsBonusProduct { get; set; }
        public double PrimaryDiscountPercent { get; set; }
        public double PrimaryDiscountValue { get; set; }
        public double SecondaryDiscountPercent { get; set; }
        public double SecondaryDiscountValue { get; set; }
        public string PrimarySchemeId { get; set; }
        public string PrimarySchemeCode { get; set; }
        public string SecondarySchemeId { get; set; }
        public double Quantity { get; set; }
        public double CGSTPercentage { get; set; }
        public double SGSTPercentage { get; set; }
        public double IGSTPercentage { get; set; }
        public double UTGSTPercentage { get; set; }
        public double PriceWithGst { get; set; }
        public double CashDiscountPercent { get; set; }
        public double CashDiscountValue { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string BatchNo { get; set; }
        public double RevisedPrice { get; set; }
        public double AdditionalDiscountPercent_1 { get; set; }
        public double AdditionalDiscountValue_1 { get; set; }
        public double AdditionalDiscountPercent_2 { get; set; }
        public double AdditionalDiscountValue_2 { get; set; }
        public string SecondarySchemeCode { get; set; }
        public bool IsSchemedProduct { get; set; }
        public double TradeDiscountPercent { get; set; }
        public double TradeDiscountValue { get; set; }
        public string ProductERPId { get; set; }
        public double FreeQty { get; set; }
        public double FOCPercent { get; set; }
        public double FOCValue { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
    }
}
