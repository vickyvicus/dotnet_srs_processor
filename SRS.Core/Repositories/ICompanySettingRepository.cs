using SRS.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Repositories
{
    public interface ICompanySettingsRepository
    {
        Task<List<CompanySettingMinModel>> GetAllCompaniesUsingOnlineDMS();
    }
}
