using Microsoft.EntityFrameworkCore;
using SRS.Core.Model;
using SRS.Postgres.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.DbContext
{
    public class DMSDbContext : Microsoft.EntityFrameworkCore.DbContext 
    {
        public DMSDbContext(DbContextOptions<DMSDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }
        public DbSet<PurchaseOrderItems> PurchaseOrderItems { get; set; }

        public DbSet<SecondarySalesInvoice> SecondarySalesInvoice { get; set; }
        public DbSet<SecondarySalesInvoiceItems> SecondarySalesInvoiceItems { get; set; }

        public DbSet<InventoryStock> InventoryStock { get; set; }

        public DbSet<SRSOrder> SRSOrders { get; set; }
        public DbSet<SRSOrderItems> SRSOrderItems { get; set; }

        public void RejectChanges()
        {
            var entries = ChangeTracker.Entries().ToList();
            foreach (var entry in entries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified; //Revert changes made to deleted entity.
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("tran");

            base.OnModelCreating(modelBuilder);
        }
    }
}
