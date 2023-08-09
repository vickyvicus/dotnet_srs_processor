using AutoMapper;
using SRS.Core.Dtos;
using SRS.Postgres.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Postgres.Mappers
{
    public class PostgresEntityMapping : Profile
    {
        public PostgresEntityMapping() {
            CreateMap<InventoryStock, InventoryInfo>();
        }
    }
}
