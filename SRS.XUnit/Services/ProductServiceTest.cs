using AutoFixture;
using Moq;
using SRS.Core.Dtos;
using SRS.Core.Interfaces;
using SRS.Core.Repositories;
using SRS.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.XUnit.Services
{
    public class ProductServiceTest
    {
        IProductService productService;

        public ProductServiceTest()
        {
            var fixture = new Fixture();
            var productRepositoryMoq = new Mock<IProductRepository>();

            productService = new ProductService(productRepositoryMoq.Object);

            productRepositoryMoq.Setup(s => s.GetProductInfoAsync(It.IsAny<long>())).
            ReturnsAsync((long companyId) =>
            {
                var list = new List<ProductEntity>() {
                    fixture.Create<ProductEntity>(),
                    fixture.Create<ProductEntity>(),
                    fixture.Create<ProductEntity>(),
                    fixture.Create<ProductEntity>()
                };

                list[1].VariantName = list[0].VariantName;
                list[1].SecondaryCategoryId = list[0].SecondaryCategoryId;
                list[1].MRPNumeric = list[0].MRPNumeric;

                list[3].VariantName = list[2].VariantName;
                list[3].SecondaryCategoryId = list[2].SecondaryCategoryId;
                list[3].MRPNumeric = list[2].MRPNumeric;

                return list;
            });
        }

        [Fact]
        public async Task GenenerateProductInfoWithCluster_Test()
        {
            var data = await productService.GenenerateProductInfoWithCluster(1234);
            var element0 = data.ProductClusterMap.ElementAt(0);
            var element1 = data.ProductClusterMap.ElementAt(1);
            var element2 = data.ProductClusterMap.ElementAt(2);
            var element3 = data.ProductClusterMap.ElementAt(3);

            Assert.True(data.ProductEntityMap.Count == 4);
            Assert.True((element0.Value == element1.Value) &&
                (element0.Key != element1.Key));
            Assert.True((element2.Value == element3.Value) &&
                (element2.Key != element3.Key));
        }
    }
}
