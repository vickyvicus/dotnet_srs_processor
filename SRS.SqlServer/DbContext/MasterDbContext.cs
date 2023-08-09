using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SRS.Core.Dtos;
using SRS.SqlServer.DbModels;

namespace SRS.SqlServer.DbContext
{
    public class MasterDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MasterDbContext(DbContextOptions<MasterDbContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSecondaryCategory> ProductSecondaryCategories { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<CompanySettingMinModel> CompanySettingMinModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanySettingMinModel>().HasNoKey().ToView("Fake1");
        }
    }
}
