using Microsoft.EntityFrameworkCore;
using SRS.Core.Dtos;
using SRS.Core.Repositories;
using SRS.Postgres.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.Repositories
{
    public class PurchaseOrderRepository : IOpenOrderRepository
    {
        private readonly DMSDbContext dMSDbContext;

        public PurchaseOrderRepository(DMSDbContext dMSDbContext)
        {
            this.dMSDbContext = dMSDbContext;
        }

        public async Task<List<OpenOrderInfo>> OpenOrderInfoAsync(long companyId,long distributorId)
        {
            var data = await dMSDbContext.PurchaseOrderItems.Where(s=>
                s.PurchaseOrder.CompanyId == companyId &&
                s.PurchaseOrder.BuyerId == distributorId &&
                string.IsNullOrEmpty(s.PurchaseOrder.SOCode)).GroupBy(s => s.ProductId).
                Select(s => new OpenOrderInfo(s.Key, (decimal)s.Sum(t => t.Quantity)))
                .ToListAsync();

            return data;
        }
    }
}
