using Microsoft.EntityFrameworkCore;
using SRS.Core.Dtos;
using SRS.Core.Repositories;
using SRS.Core.Utils;
using SRS.Postgres.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.Repositories
{
    public class SecondarySalesRepository : IStockNormSalesRepository, IInTransitOrderRepository
    {
        private readonly DMSDbContext dMSDbContext;

        public SecondarySalesRepository(DMSDbContext dMSDbContext)
        {
            this.dMSDbContext = dMSDbContext;
        }

        public async Task<List<StockNorm>> StockNorm_ProductWiseAsync(long companyId,
            long distributorId,DateRange dateRange, int frequency)
        {
            var data = await dMSDbContext.SecondarySalesInvoiceItems.Where(
                s => s.SecondarySalesInvoice.CompanyId == companyId &&
                s.SecondarySalesInvoice.BuyerId == distributorId &&
                s.SecondarySalesInvoice.CreatedAt >= dateRange.FromDate &&
                s.SecondarySalesInvoice.CreatedAt <= dateRange.ToDate).GroupBy(s => s.ProductId).
                Select(s => new StockNorm(s.Key, s.Sum(t => t.Quantity) / frequency))
                .ToListAsync();

            return data;
        }

        public async Task<List<InTransitInfo>> InTransitOrder_ProductWiseAsync(long companyId,
            long distributorId)
        {
            var data = await dMSDbContext.SecondarySalesInvoiceItems.Where(
                s => s.SecondarySalesInvoice.CompanyId == companyId &&
                s.SecondarySalesInvoice.BuyerId == distributorId && 
                !s.SecondarySalesInvoice.IsGRDone).GroupBy(s=>s.ProductId).Select(s=>
                    new InTransitInfo(s.Key, s.Sum(t => t.Quantity)))
                .ToListAsync();

            return data;
        }
    }
}
