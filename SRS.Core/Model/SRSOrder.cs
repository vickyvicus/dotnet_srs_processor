using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Model
{
    [Table("SRSOrders")]
    public class SRSOrder
    {
        public SRSOrder()
        {

        }

        public SRSOrder(long distributorId,long companyId,string orderCode) {
            this.DistributorId = distributorId;
            this.CompanyId = companyId;
            this.OrderErpCode = orderCode;
        }
        public long Id { get; set; }
        public long DistributorId { get; set; }
        public string OrderErpCode { get; set; }
        public long CompanyId { get; set; }
        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsExpired { get; set; }

        public List<SRSOrderItems> SRSOrderItems { get; set; }
    }

}
