using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.DbModels
{
    public class InventoryStock
    {
        [Key]
        public long Id { get; set; }
        public long ProductId { get; set; }
        public long CompanyId { get; set; }
        public long DistributerId { get; set; }
        public string ProductErpId { get; set; }
        public int CurrentStock { get; set; }
    }
}
