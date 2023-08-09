using Library.CommonEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.SqlServer.DbModels
{
    [Table("FADistributors")]
    public class Distributor
    {
        public long Id { get; set; }

        public long CompanyId { get; set; }

        public string? Name { get; set; }

        public string? ContactNo { get; set; }

        public string? Username { get; set; }

        public string? passwordHash { get; set; }

        public DateTime TimeAdded { get; set; }

        public Guid Guid { get; set; }

        public string? EmailId { get; set; }

        public string? ClientSideId { get; set; }

        public string? Place { get; set; }

        public string? ManagerName { get; set; }

        public string? Zone { get; set; }

        public string? State { get; set; }

        public string? Address { get; set; }

        public string? PinCode { get; set; }

        public bool IsDeactive { get; set; }

        public string? SecondaryEmailId { get; set; }

        public string? DistributorType { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        public string? CreationContext { get; set; }

        public long? SuperStockistId { get; set; }

        public Guid? LoginGuid { get; set; }

        public bool Deleted { get; set; }

        public long? RegionId { get; set; }

        public string? LocalName { get; set; }

        public long? ParentId { get; set; }

        public StockistType StockistType { get; set; }

        public bool IsAppUser { get; set; }

        public string? ImageId { get; set; }

        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        public double? GeoAccuracy { get; set; }

        public string? GSTIN { get; set; }
        public string? PlaceOfSupply { get; set; }
    }
}
