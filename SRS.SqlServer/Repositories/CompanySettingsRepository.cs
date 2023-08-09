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
    public class CompanySettingsRepository : ICompanySettingsRepository
    {
        private readonly MasterDbContext dbContext;

        public CompanySettingsRepository(MasterDbContext masterDbContext)
        {
            this.dbContext = masterDbContext;
        }

        public async Task<List<CompanySettingMinModel>> GetAllCompaniesUsingOnlineDMS()
        {
            return await dbContext.CompanySettingMinModel.FromSqlRaw(@$"Select distinct csv.companyId as CompanyId from CompanySettings cs
                                                                    join CompanySettingValues csv on cs.Id = csv.SettingId
                                                                    where cs.SettingKey = 'IsOnlineDMS'
                                                                    and csv.SettingValue = 'true'").ToListAsync();
        }
    }
}
