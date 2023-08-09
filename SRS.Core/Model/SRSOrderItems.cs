using SRS.Core.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Model
{
    [Table("SRSOrderItems")]
    public class SRSOrderItems
    {
        public SRSOrderItems()
        {

        }

        public SRSOrderItems(ProductEntity productEntity,decimal normQty,
            decimal openQty, decimal inTransistQty, decimal inventoryQty)
        {
            ProductId = productEntity.Id;
            ProductName = productEntity.Name;
            ProductErpCode = productEntity.ErpCode;
            MRP = productEntity.MRPNumeric;

            StockNormQuantity = normQty;
            StockNormInCases = normQty / (decimal)productEntity.StandardUnitConversionFactor;
            StockNormInPieces = normQty % (decimal)productEntity.StandardUnitConversionFactor;

            InventoryQuantity = inventoryQty;
            InventoryInCases = inventoryQty / (decimal)productEntity.StandardUnitConversionFactor;
            InventoryInPieces = inventoryQty % (decimal)productEntity.StandardUnitConversionFactor;

            OpenOrderQuantity = openQty;
            OpenOrderInCases = openQty / (decimal)productEntity.StandardUnitConversionFactor;
            OpenOrderInPieces = openQty % (decimal)productEntity.StandardUnitConversionFactor;

            InTransistQuantity = inTransistQty;
            InTransistInCases = inTransistQty / (decimal)productEntity.StandardUnitConversionFactor;
            InTransistInPieces = inTransistQty % (decimal)productEntity.StandardUnitConversionFactor;

            RecommendedQuantity = StockNormQuantity - InventoryQuantity - OpenOrderQuantity -
                InTransistQuantity;
            RecommendedInCases = StockNormInCases - InventoryInCases - OpenOrderInCases -
                InTransistInCases;
            RecommendedInPieces = StockNormInPieces - InventoryInPieces - OpenOrderInPieces -
                InTransistInPieces;
        }

        public long Id { get; set; }
        public long SRSOrderId { get; set; }
        public SRSOrder SRSOrder { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }

        public long ProductId { get; set; }
        public string ProductErpCode { get; set; }
        public string ProductName { get; set; }
        public decimal MRP { get; set; }

        public decimal RecommendedQuantity { get; set; }
        public decimal RecommendedInCases { get; set; }
        public decimal RecommendedInPieces { get; set; }

        public decimal InventoryQuantity { get; set; }
        public decimal InventoryInCases { get; set; }
        public decimal InventoryInPieces { get; set; }

        public decimal StockNormQuantity { get; set; }
        public decimal StockNormInCases { get; set; }
        public decimal StockNormInPieces { get; set; }


        public decimal InTransistQuantity { get; set; }
        public decimal InTransistInCases { get; set; }
        public decimal InTransistInPieces { get; set; }


        public decimal OpenOrderQuantity { get; set; }
        public decimal OpenOrderInCases { get; set; }
        public decimal OpenOrderInPieces { get; set; }

    }
}
