using SRS.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Repositories
{
    public interface IOpenOrderRepository
    {
        Task<List<OpenOrderInfo>> OpenOrderInfoAsync(long companyId, long distributorId);
    }
}
