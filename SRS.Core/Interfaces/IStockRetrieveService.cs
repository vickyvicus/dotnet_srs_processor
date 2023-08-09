using SRS.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Interfaces
{
    public interface IStockRetrieveService
    {
        Task<Dictionary<long, decimal>> OpenOrder_NormWise(Dictionary<long, long> ProductClusterMap,
           long distributorId,
          long companyId);
        Task<Dictionary<long, decimal>> GenerateStockNorm(Dictionary<long, long> ProductClusterMap,
            long distributorId, long companyId, DateRange dateRange,
            int frequency);
        Task<Dictionary<long, decimal>> CurrentInventory_NormWise(Dictionary<long, long> ProductClusterMap,
            long distributorId,
            long companyId);
        Task<Dictionary<long, decimal>> InTransist_NormWise(Dictionary<long, long> ProductClusterMap,
            long distributorId,
            long companyId);
    }
}
