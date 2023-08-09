using System;
using System.Threading.Tasks;
using AutoFixture;
using Moq;
using SRS.Core.Model;
using Xunit;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoFixture;
using Moq;
using Xunit;
using SRS.Postgres.DbContext;
using Microsoft.EntityFrameworkCore;
using SRS.Postgres.Repositories;
using Microsoft.EntityFrameworkCore.InMemory;
using SRS.Core.Interfaces;
using SRS.Core.Repositories;
using SRS.Core.Services;
using SRS.Core.Utils;
using SRS.Core.Dtos;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SRS.XUnit.Services
{
    

    public class SRSServiceTests
    {
        private readonly Fixture fixture;
        private readonly Mock<IProductService> productServiceMock;
        private readonly Mock<IStockRetrieveService> stockRetrieveServiceMock;
        private readonly ISrsOrderRepository srsOrderRepositoryMock;
        private readonly SRSService srsService;
        private readonly DMSDbContext dMSDbContext;

        public SRSServiceTests()
        {
            fixture = new Fixture();
            fixture.Behaviors.Remove(new ThrowingRecursionBehavior());
            fixture.Behaviors.Add(new OmitOnRecursionBehavior());
            productServiceMock = new Mock<IProductService>();
            stockRetrieveServiceMock = new Mock<IStockRetrieveService>();
            //srsOrderRepositoryMock = new Mock<ISrsOrderRepository>();

            //Setup In Memory
            var options = (new DbContextOptionsBuilder<DMSDbContext>())
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .ConfigureWarnings(warnings => warnings.Ignore(InMemoryEventId.TransactionIgnoredWarning))
            .Options;

            dMSDbContext = new DMSDbContext(options);
            srsOrderRepositoryMock = new SRSOrderRepository(dMSDbContext);

            srsService = new SRSService(stockRetrieveServiceMock.Object, srsOrderRepositoryMock,
                productServiceMock.Object);
        }

        [Fact]
        public async Task GenerateSrsOrder_Should_Create_SrsOrder_And_Commit()
        {
            // Arrange
            long distributorId = 1;
            long companyId = 2;
            DateRange dateRange = new DateRange(DateTime.Now, DateTime.Now.AddDays(7));
            int frequency = 7;
            var product11 = fixture.Create<ProductEntity>();
            product11.Id = 11;
            var product13 = fixture.Create<ProductEntity>();
            product13.Id = 13;

            var productInfoWithCluster = new ProductInfoWithCluster(
                new Dictionary<long, ProductEntity> { { 11,
                product11 },{ 13,
                product13 } },
                new Dictionary<long, long>() { { 12, 11 }, { 11, 11 }, { 13, 13 } }
            );
            productServiceMock.Setup(service => service.GenenerateProductInfoWithCluster(companyId))
                .ReturnsAsync(productInfoWithCluster);

            var stockNormMap = new Dictionary<long, decimal>() { { 11, 100 },{ 13,200} };
            stockRetrieveServiceMock.Setup(service => service.GenerateStockNorm(
                 productInfoWithCluster.ProductClusterMap, distributorId, companyId,
                 dateRange, frequency))
                .ReturnsAsync(stockNormMap);

            var normWiseInventoryMap = new Dictionary<long, decimal>() { { 11, 20 }, { 13, 25 } };
            stockRetrieveServiceMock.Setup(service => service.CurrentInventory_NormWise(
                productInfoWithCluster.ProductClusterMap, distributorId, companyId))
                .ReturnsAsync(normWiseInventoryMap);

            var normWiseInTransistMap = new Dictionary<long, decimal>() { { 11, 5 }, { 13, 10 } };
            stockRetrieveServiceMock.Setup(service => service.InTransist_NormWise(
                productInfoWithCluster.ProductClusterMap, distributorId, companyId))
                .ReturnsAsync(normWiseInTransistMap);

            var normWiseOpenOrderMap = new Dictionary<long, decimal>() { { 11, 10 }, { 13, 15 } };
            stockRetrieveServiceMock.Setup(service => service.OpenOrder_NormWise(
                productInfoWithCluster.ProductClusterMap, distributorId, companyId))
                .ReturnsAsync(normWiseOpenOrderMap);

           
            // Act
            await srsService.GenerateSrsOrder(distributorId, companyId, dateRange, frequency);

            // Assert
            var order = await dMSDbContext.SRSOrders.Include(s=>s.SRSOrderItems).FirstOrDefaultAsync();
            Assert.NotNull(order);
            Assert.NotNull(order.SRSOrderItems);
            Assert.Equal(order.SRSOrderItems.Where(s => s.ProductId == 11).FirstOrDefault()?.RecommendedQuantity
                , 65);
            Assert.Equal(order.SRSOrderItems.Where(s => s.ProductId == 13).FirstOrDefault()?.RecommendedQuantity
                , 150);
        }

        [Fact]
        public void CreateSrsOrder_Should_Create_Valid_SrsOrder()
        {
            // Arrange
            long distributorId = 1;
            long companyId = 2;
            var srsServiceInstance = new SRSService(stockRetrieveServiceMock.Object,
                srsOrderRepositoryMock, productServiceMock.Object);

            // Act
            var srsOrder = InvokeCreateSrsOrder(srsServiceInstance, distributorId, companyId);

            // Assert
            Assert.NotNull(srsOrder);
            Assert.Equal(distributorId, srsOrder.DistributorId);
            Assert.Equal(companyId, srsOrder.CompanyId);
            // Add more specific assertions for the SrsOrder properties as needed
        }

        // Helper method to invoke private CreateSrsOrder method using reflection
        private SRSOrder InvokeCreateSrsOrder(SRSService srsServiceInstance, long distributorId, long companyId)
        {
            var createSrsOrderMethod = typeof(SRSService).GetMethod("CreateSrsOrder",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            return (SRSOrder)createSrsOrderMethod.Invoke(srsServiceInstance, new object[] { distributorId, companyId });
        }

        // Add more test cases for other private methods as needed
    }


}
