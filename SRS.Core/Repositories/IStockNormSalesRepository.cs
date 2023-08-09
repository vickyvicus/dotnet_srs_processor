using SRS.Core.Dtos;
using SRS.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Repositories
{
    public interface IStockNormSalesRepository
    {
        Task<List<StockNorm>> StockNorm_ProductWiseAsync(long companyId,
            long distributorId,
            DateRange dateRange, int frequency);
    }
}
