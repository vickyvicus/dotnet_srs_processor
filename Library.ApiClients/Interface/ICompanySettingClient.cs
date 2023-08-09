using Library.ApiClients.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ApiClients.Interface
{
    public interface ICompanySettingClient
    {
        Task<CompanySettingModel> GetCompanySetting(long companyId);
    }
}
