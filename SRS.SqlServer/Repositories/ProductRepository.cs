using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
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
    public class ProductRepository : IProductRepository
    {
        private readonly MasterDbContext masterDbContext;
        private readonly IMapper mapper;

        public ProductRepository(MasterDbContext masterDbContext,
            IMapper mapper)
        {
            this.masterDbContext = masterDbContext;
            this.mapper = mapper;
        }

        public async Task<List<ProductEntity>> GetProductInfoAsync(long companyId)
        {
            var data = await masterDbContext.Products.Where(s => s.CompanyId == companyId).
                Select(s => mapper.Map<ProductEntity>(s)).ToListAsync();

            return data;
        }
    }
}
