using SRS.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Interfaces
{
    public interface ISRSService
    {
        Task GenerateSrsOrder(long distributorId, long companyId, DateRange dateRange,
            int frequency);
    }
}
