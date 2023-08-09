using SRS.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Repositories
{
    public interface ISrsOrderRepository
    {
        Task StartTransaction();
        Task SetExpiredToAllPreviousOrders(long companyId, long distributorId);
        Task CommitTransaction();
        Task RollbackTransaction();
        Task DisposeTransaction();
        Task SaveCurrentSrsOrderWithItems(SRSOrder sRSOrders);
    }
}
