using AutoMapper;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SRS.SqlServer.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SRS.Core.Dtos;

namespace SRS.SqlServer.Mappers
{
    public class SQLEntityMapping : Profile
    {
        public SQLEntityMapping()
        {
            CreateMap<Product, ProductEntity>().
                ForMember(s => s.SecondaryCategoryName, s => s.MapFrom(t =>t.ProductCategory.Name));
            CreateMap<Distributor, DistributorInfo>();
        }
    }
}
