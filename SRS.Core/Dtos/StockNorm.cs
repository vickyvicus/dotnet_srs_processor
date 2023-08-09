using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Dtos
{
    public class StockNorm
    {
        public StockNorm()
        {

        }

        public StockNorm(long productId,decimal quantity) 
        {
            this.ProductId = productId;
            this.Quantity = quantity;
        }

        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}
