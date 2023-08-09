using SRS.Core.Dtos;
using SRS.Core.Interfaces;
using SRS.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        public async Task<ProductInfoWithCluster> GenenerateProductInfoWithCluster(long companyId)
        {
            var allProducts = await productRepository.GetProductInfoAsync(companyId);
            Dictionary<long, ProductEntity> ProductEntityMap = allProducts.ToDictionary(s => s.Id, s => s);

#pragma warning disable CS8602 // Dereference of a possibly null reference.
            var primaryProductMap = allProducts.GroupBy(s => new { s.MRPNumeric, s.SecondaryCategoryId, s.VariantName }).
                Where(s=>s.Where(t => t.IsActive && !t.Deleted).Count()>0).
                ToDictionary(s => s.Where(s => s.IsActive && !s.Deleted).OrderByDescending(t => t.LastUpdatedAt).
                FirstOrDefault().Id, s => s.Select(t => t.Id).ToList());
#pragma warning restore CS8602 // Dereference of a possibly null reference.

            Dictionary<long, long> ProductClusterMap = new Dictionary<long, long>();
            foreach (var item in primaryProductMap)
            {
                item.Value.ForEach(s => { ProductClusterMap.Add(s, item.Key); });
            }

            return new ProductInfoWithCluster(ProductEntityMap, ProductClusterMap);
        }
    }
}
