using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SRS.Core.Dtos;
using SRS.Core.Repositories;
using SRS.Core.Utils;
using SRS.Postgres.DbContext;
using SRS.Postgres.DbModels;

namespace SRS.Postgres.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly DMSDbContext dMSDbContext;
        private readonly IMapper mapper;

        public InventoryRepository(DMSDbContext dMSDbContext,
            IMapper mapper) {
            this.dMSDbContext = dMSDbContext;
            this.mapper = mapper;
        }

        public async Task<List<InventoryInfo>> InventoryInfosAsync(long companyId,long distributor)
        {
            var data = await dMSDbContext.InventoryStock.Where(s => s.CompanyId == companyId
            && s.DistributerId == distributor).Select(
                s => mapper.Map<InventoryInfo>(s)
                ).ToListAsync();

            return data;
        }
    }
}
