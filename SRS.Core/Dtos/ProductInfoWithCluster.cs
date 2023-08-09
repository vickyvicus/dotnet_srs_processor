using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Core.Dtos
{
    public class ProductInfoWithCluster
    {
        public ProductInfoWithCluster(Dictionary<long, ProductEntity> productEntityMap, Dictionary<long, long> productClusterMap)
        {
            ProductEntityMap = productEntityMap;
            ProductClusterMap = productClusterMap;
        }

        public Dictionary<long, ProductEntity> ProductEntityMap { get; set; }
        public Dictionary<long, long> ProductClusterMap { get; set; }
    }
}
