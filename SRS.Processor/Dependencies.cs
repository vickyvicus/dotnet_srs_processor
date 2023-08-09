using AutoMapper;
using Library.ApiClients.Implementation;
using Library.ApiClients.Interface;
using Library.ApiClients.Models;
using Library.Logger;
using Library.Logger.Clients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SRS.Core.Interfaces;
using SRS.Core.Processor;
using SRS.Core.Repositories;
using SRS.Core.Services;
using SRS.Postgres.DbContext;
using SRS.Postgres.Mappers;
using SRS.Postgres.Repositories;
using SRS.SqlServer.DbContext;
using SRS.SqlServer.Mappers;
using SRS.SqlServer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Processor
{
    public static class Dependencies
    {
        private static void SqlResiliencyBuilder(SqlServerDbContextOptionsBuilder o)
        {
            o.EnableRetryOnFailure();
        }

        public static void SetUp(IServiceCollection serviceProvider, IConfiguration configuration)
        {
            var masterDbConnectionString = GetConnectionString(configuration, "MasterDbConnectionString");
            var transactionDbConnectionString = GetConnectionString(configuration, "TransactionDbConnectionString");
            //var readOnlyDmsDbConnectionString = GetConnectionString(configuration, "ReadonlyDMSDbConnectionString");
            var masterStorageConnectionString = GetConnectionString(configuration, "MasterStorageConnectionString");
            //var telegramIrisBotToken = GetConfigString(configuration, "AuthSettings:TelegramIrisBotToken");

            //Client Registration
            serviceProvider.AddScoped<ICompanySettingClient, CompanySettingClient>();
            serviceProvider.AddSingleton<MyLogger>();
            serviceProvider.AddHttpClient<IDiscordLogger, DiscordLogger>(c =>
            {
                c.BaseAddress = new Uri(configuration.GetValue<string>("AuthSettings:DiscordURI"));
            });
            serviceProvider.AddSingleton(s => new CompanyConfigSettings
            {
                CompanySettingUsername = configuration.GetValue<string>("AuthSettings:CompanySettingUsername"),
                CompanySettingPassword = configuration.GetValue<string>("AuthSettings:CompanySettingPassword"),
                CompanySettingBaseUrl = configuration.GetValue<string>("AuthSettings:CompanySettingBaseUrl")
            });

            //Add Mapper
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new PostgresEntityMapping());
                mc.AddProfile(new SQLEntityMapping());
            });
            var mapper = mappingConfig.CreateMapper();
            serviceProvider.AddSingleton(mapper);

            // SFA master database
            serviceProvider.AddDbContext<MasterDbContext>(options =>
                options.UseSqlServer(masterDbConnectionString, SqlResiliencyBuilder));

            // DMS database
            serviceProvider.AddDbContext<DMSDbContext>(options =>
                options.UseNpgsql(GetConnectionString(configuration, "DMSDbConnectionString")));

            //Inject Service Dependency
            serviceProvider.AddScoped<IProductService, ProductService>();
            serviceProvider.AddScoped<ISRSService, SRSService>();
            serviceProvider.AddScoped<IStockRetrieveService, StockRetrieveService>();

            //Injecting processor dependency
            serviceProvider.AddScoped<ISRSProcessor, SRSProcessor>();

            //Inject Master Dependency
            serviceProvider.AddScoped<IProductRepository, ProductRepository>();
            serviceProvider.AddScoped<IDistributorRepository, DistributorRepository>();
            serviceProvider.AddScoped<ICompanySettingsRepository, CompanySettingsRepository>();

            //Inject DMS Stock Dependency
            serviceProvider.AddScoped<IInventoryRepository, InventoryRepository>();
            serviceProvider.AddScoped<IInTransitOrderRepository, SecondarySalesRepository>();
            serviceProvider.AddScoped<IOpenOrderRepository, PurchaseOrderRepository>();
            serviceProvider.AddScoped<IStockNormSalesRepository, SecondarySalesRepository>();
            serviceProvider.AddScoped<ISrsOrderRepository, SRSOrderRepository>();

        }

        private static string GetConnectionString(IConfiguration configuration, string key)
        {
            return configuration.GetConnectionString(key) ?? throw new NullReferenceException();
        }

        private static string GetConfigString(IConfiguration configuration, string key)
        {
            return configuration.GetValue<string>(key) ?? throw new NullReferenceException();
        }
    }
}
