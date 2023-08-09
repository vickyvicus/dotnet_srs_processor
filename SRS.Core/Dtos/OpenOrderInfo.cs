using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Dtos
{
    public class OpenOrderInfo
    {
        public OpenOrderInfo()
        {

        }

        public OpenOrderInfo(long productId, decimal quantity)
        {
            ProductId = productId;
            Quantity = quantity;
        }

        public long ProductId { get; set; }
        public decimal Quantity { get; set; }
    }
}
