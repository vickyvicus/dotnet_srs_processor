using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SRS.Core.Dtos;
using SRS.Core.Repositories;
using SRS.SqlServer.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.SqlServer.Repositories
{
    public class DistributorRepository : IDistributorRepository
    {
        private readonly MasterDbContext masterDbContext;
        private readonly IMapper mapper;

        public DistributorRepository(MasterDbContext masterDbContext,
            IMapper mapper)
        {
            this.masterDbContext = masterDbContext;
            this.mapper = mapper;
        }

        public async Task<List<DistributorInfo>> GetDistributors(long companyId)
        {
            var data = await masterDbContext.Distributors.Where(s => s.CompanyId ==
                companyId && !s.IsDeactive && !s.Deleted).Select(s=>
                    mapper.Map<DistributorInfo>(s)).ToListAsync();

            return data;
        }
    }
}
