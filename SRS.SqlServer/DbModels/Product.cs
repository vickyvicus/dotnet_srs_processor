using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.SqlServer.DbModels
{
    [Table("FACompanyProducts")]
    public class Product
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? VariantName { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
        public long CompanyId { get; set; }
        public string? Unit { get; set; }
        public decimal? UnitWeight { get; set; }
        public double StandardUnitConversionFactor { get; set; }
        public string? ErpCode { get; set; }
        public long ProductCategoryId { get; set; }
        public string? Category1 { get; set; }
        public long? ProductDisplayCategoryId { get; set; }
        public long? ProductGSTCategoryId { get; set; }
        public double Price { get; set; }
        public string? MRP { get; set; }
        public string? ColorName { get; set; }
        public int? DisplayOrder { get; set; }
        public int? ExpiryInDays { get; set; }
        public int MBQ { get; set; }
        public string? Schemes { get; set; }
        public bool IsPromoted { get; set; }
        public decimal MRPNumeric { get; set; }
        public decimal? NetWeight { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal PTD { get; set; }
        public int? HSNCode { get; set; }

        public decimal? PTDSub { get; set; }
        public decimal? PTDSuper { get; set; }
        public decimal? PTRMT { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public virtual ProductSecondaryCategory ProductCategory { get; set; }
    }
}
