using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using SRS.Core.Model;
using SRS.Core.Repositories;
using SRS.Postgres.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.Repositories
{
    public class SRSOrderRepository : ISrsOrderRepository
    {
        private readonly DMSDbContext dMSDbContext;
        private IDbContextTransaction dbContextTransaction;

        public SRSOrderRepository(DMSDbContext dMSDbContext)
        {
            this.dMSDbContext = dMSDbContext;
        }

        public async Task CommitTransaction()
        {
            await dbContextTransaction.CommitAsync();
        }

        public async Task RollbackTransaction()
        {
            await dbContextTransaction.RollbackAsync();
        }

        public async Task DisposeTransaction()
        {
            await dbContextTransaction.DisposeAsync();
        }

        public async Task SaveCurrentSrsOrderWithItems(SRSOrder sRSOrders)
        {
            await dMSDbContext.SRSOrders.AddAsync(sRSOrders);
            await dMSDbContext.SaveChangesAsync();
        }

        public async Task SetExpiredToAllPreviousOrders(long companyId,long distributorId)
        {
            var allPreviousOrders = await dMSDbContext.SRSOrders.Where(s => s.CompanyId == companyId
                && s.DistributorId == distributorId).ToListAsync();
            allPreviousOrders.ForEach(s => s.IsExpired = true);
            dMSDbContext.SRSOrders.UpdateRange(allPreviousOrders);
        }

        public async Task StartTransaction()
        {
            if (dMSDbContext.ChangeTracker.HasChanges())
            {
                dMSDbContext.RejectChanges();
            }

            dbContextTransaction = await dMSDbContext.Database.BeginTransactionAsync();
        }

    }
}
