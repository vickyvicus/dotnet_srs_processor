using SRS.Core.Dtos;
using SRS.Core.Interfaces;
using SRS.Core.Repositories;
using SRS.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Services
{
    public class StockRetrieveService : IStockRetrieveService
    {
        private readonly IStockNormSalesRepository stockNormSalesRepository;
        private readonly IInventoryRepository inventoryRepository;
        private readonly IInTransitOrderRepository inTransitOrderRepository;
        private readonly IOpenOrderRepository openOrderRepository;

        public StockRetrieveService(IStockNormSalesRepository
            stockNormSalesRepository, IInventoryRepository inventoryRepository,
            IInTransitOrderRepository inTransitOrderRepository,
            IOpenOrderRepository openOrderRepository)
        {
            this.stockNormSalesRepository = stockNormSalesRepository;
            this.inventoryRepository = inventoryRepository;
            this.inTransitOrderRepository = inTransitOrderRepository;
            this.openOrderRepository = openOrderRepository;
        }

        public async Task<Dictionary<long, decimal>> OpenOrder_NormWise(Dictionary<long, long> ProductClusterMap,
            long distributorId,
           long companyId)
        {
            var openOrderProductWise = await openOrderRepository.
                OpenOrderInfoAsync(companyId, distributorId);

            var openOrderNormWise = openOrderProductWise.GroupBy(s =>
                ProductClusterMap.TryGetValue(s.ProductId, out var productId) ? productId
                : 0).Where(s => s.Key != 0).Select(s => new OpenOrderInfo(s.Key, s.Sum(t => t.Quantity)))
                .ToDictionary(s => s.ProductId, s => s.Quantity); ;

            return openOrderNormWise;
        }

        public async Task<Dictionary<long, decimal>> GenerateStockNorm(Dictionary<long, long> ProductClusterMap,
            long distributorId, long companyId, DateRange dateRange,
            int frequency)
        {
            var productWiseSales = await stockNormSalesRepository.
                StockNorm_ProductWiseAsync(companyId, distributorId, dateRange, frequency);

            var stockNorm = productWiseSales.GroupBy(s =>
                ProductClusterMap.TryGetValue(s.ProductId, out var productId) ? productId
                : 0).Where(s => s.Key != 0).Select(s => new StockNorm(s.Key, s.Sum(t => t.Quantity)))
                .ToDictionary(s => s.ProductId, s => s.Quantity);

            return stockNorm;
        }

        public async Task<Dictionary<long, decimal>> CurrentInventory_NormWise(Dictionary<long, long> ProductClusterMap,
            long distributorId,
            long companyId)
        {
            var currentInventory = await inventoryRepository.
                InventoryInfosAsync(companyId, distributorId);

            var normWiseStock = currentInventory.GroupBy(s =>
                ProductClusterMap.TryGetValue(s.ProductId, out var productId) ? productId
                : 0).Where(s => s.Key != 0).Select(s => new InventoryInfo(s.Key, s.Sum(t => t.Stock))).
                ToDictionary(s => s.ProductId, s => s.Stock);

            return normWiseStock;
        }

        public async Task<Dictionary<long, decimal>> InTransist_NormWise(Dictionary<long, long> ProductClusterMap,
            long distributorId,
            long companyId)
        {
            var inTransitInfos = await inTransitOrderRepository.
                InTransitOrder_ProductWiseAsync(companyId, distributorId);

            var normWiseIntransist = inTransitInfos.GroupBy(s =>
                ProductClusterMap.TryGetValue(s.ProductId, out var productId) ? productId
                : 0).Where(s => s.Key != 0).Select(s => new InTransitInfo(s.Key, s.Sum(t => t.Quantity)))
                .ToDictionary(s => s.ProductId, s => s.Quantity);

            return normWiseIntransist;
        }
    }
}
