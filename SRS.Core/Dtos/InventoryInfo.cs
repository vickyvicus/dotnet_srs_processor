using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Dtos
{
    public class InventoryInfo
    {
        public InventoryInfo()
        {

        }

        public InventoryInfo(long productid, decimal stock)
        {
            this.ProductId = productid;
            this.Stock = stock;
        } 

        public long ProductId { get; set; }
        public decimal Stock { get; set; }
    }
}
