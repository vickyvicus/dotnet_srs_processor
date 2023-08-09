using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Dtos
{
    public class ProductEntity
    {
        //public ProductInfo(long id, string name, string variantName,
        //    string erpCode, string secondaryCategoryName, string mRP)
        //{
        //    Id = id;
        //    Name = name;
        //    VariantName = variantName;
        //    ErpCode = erpCode;
        //    SecondaryCategoryName = secondaryCategoryName;
        //    MRP = mRP;
        //}

        public long Id { get; set; }
        public string Name { get; set; }
        public string VariantName { get; set; }
        public string ErpCode { get; set; }
        public string SecondaryCategoryName { get; set; }
        public string SecondaryCategoryId { get; set; }

        public decimal MRPNumeric { get; set; }
        public DateTime LastUpdatedAt { get; set; }
        public double StandardUnitConversionFactor { get; set; }
        public bool IsActive { get; set; }
        public bool Deleted { get; set; }
    }
}
