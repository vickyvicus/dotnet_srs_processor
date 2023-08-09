using SRS.Core.Dtos;
using SRS.Core.Exceptions;
using SRS.Core.Interfaces;
using SRS.Core.Model;
using SRS.Core.Repositories;
using SRS.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Services
{
    public class SRSService : ISRSService
    {
        private readonly IStockRetrieveService stockRetrieveService;
        private readonly ISrsOrderRepository srsOrderRepository;
        private readonly IProductService productService;

        public SRSService(
            IStockRetrieveService stockRetrieveService, ISrsOrderRepository srsOrderRepository,
            IProductService productService)
        {
            this.stockRetrieveService = stockRetrieveService;
            this.srsOrderRepository = srsOrderRepository;
            this.productService = productService;
        }

        public async Task GenerateSrsOrder(long distributorId, long companyId, DateRange dateRange,
            int frequency)
        {
            var productInfoWithCluster = await productService.GenenerateProductInfoWithCluster(companyId);

            var stockNormMap = await stockRetrieveService.GenerateStockNorm(
                productInfoWithCluster.ProductClusterMap,
                distributorId: distributorId, companyId: companyId, dateRange, frequency);
            var normWiseInventoryMap = await stockRetrieveService.CurrentInventory_NormWise(
                productInfoWithCluster.ProductClusterMap,
                distributorId: distributorId, companyId: companyId);
            var normWiseInTransistMap = await stockRetrieveService.InTransist_NormWise(
                productInfoWithCluster.ProductClusterMap,
                distributorId: distributorId, companyId: companyId);
            var normWiseOpenOrderMap = await stockRetrieveService.OpenOrder_NormWise(
                productInfoWithCluster.ProductClusterMap,
                distributorId: distributorId, companyId: companyId);

            var srsOrder = CreateSrsOrder(distributorId, companyId);
            srsOrder.SRSOrderItems = CreateSrsOrderItems(
                ProductEntityMap: productInfoWithCluster.ProductEntityMap,
                stockNorm: stockNormMap,
                inventoryMap: normWiseInventoryMap,
                InTransistMap: normWiseInTransistMap,
                openOrderMap: normWiseOpenOrderMap);

            await CommitSRSOrder(companyId: companyId, distributorId: distributorId, srsOrder);
        }

        private async Task CommitSRSOrder(long companyId, long distributorId, SRSOrder srsOrder)
        {
            try
            {
                await srsOrderRepository.StartTransaction();
                await srsOrderRepository.SetExpiredToAllPreviousOrders(companyId, distributorId);
                await srsOrderRepository.SaveCurrentSrsOrderWithItems(srsOrder);
                await srsOrderRepository.CommitTransaction();
            }
            catch (Exception ex)
            {
                await srsOrderRepository.RollbackTransaction();
                await srsOrderRepository.DisposeTransaction();
                throw new SRSOrderDidNotCommitException();
            }
        }


        #region SRS Object Creation Region 
        private SRSOrder CreateSrsOrder(long distributorId, long companyId)
        {
            var srsOrder = new SRSOrder(distributorId: distributorId, companyId: companyId, distributorId +
                DateTime.Now.ToString("yyyyMMdd"));

            return srsOrder;
        }

        private List<SRSOrderItems> CreateSrsOrderItems(
            Dictionary<long, ProductEntity> ProductEntityMap,
            Dictionary<long, decimal> stockNorm,
            Dictionary<long, decimal> inventoryMap,
            Dictionary<long, decimal> InTransistMap,
            Dictionary<long, decimal> openOrderMap)
        {
            var srsItemOrders = stockNorm.Select(s =>
            {
                var productInfo = ProductEntityMap.TryGetValue(s.Key, out var product) ? product : null;
                if (productInfo == null)
                    throw new ProductDoesNotExistsException();

                var inventoryQty = inventoryMap.TryGetValue(s.Key, out var inventoryValue) ? inventoryValue :
                    0;
                var inTransistQty = InTransistMap.TryGetValue(s.Key, out var inTransistValue) ? inTransistValue :
                    0;
                var openQty = openOrderMap.TryGetValue(s.Key, out var openQtyValue) ? openQtyValue :
                    0;

                return new SRSOrderItems(productEntity: productInfo, normQty: s.Value,
                    openQty: openQty, inTransistQty: inTransistQty, inventoryQty: inventoryQty
                    );
            }).ToList();

            return srsItemOrders;
        }

        #endregion 

    }
}
