using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SRS.Core.Interfaces;

namespace SRS.Processor
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = new HostBuilder()
            .ConfigureAppConfiguration((config) =>
            {
                config.AddJsonFile($"appsettings.json", optional: true, reloadOnChange: true);
                var keyVaultEndpoint = Environment.GetEnvironmentVariable("KEYVAULT_ENDPOINT");
                if (!string.IsNullOrEmpty(keyVaultEndpoint))
                {
                    var azureServiceTokenProvider = new AzureServiceTokenProvider();
                    var keyVaultClient = new KeyVaultClient(
                        new KeyVaultClient.AuthenticationCallback(
                            azureServiceTokenProvider.KeyVaultTokenCallback));
                    config.AddAzureKeyVault(
                    keyVaultEndpoint, keyVaultClient, new DefaultKeyVaultSecretManager());
                }
                config.AddEnvironmentVariables();
            })
            .ConfigureServices((context, services) =>
            {
                Dependencies.SetUp(services, context.Configuration);
            })
            .UseConsoleLifetime();
            var host = builder.Build();
            using (host)
            {
                var syncProcessor = (ISRSProcessor)host.Services.GetService(typeof(ISRSProcessor));
                await syncProcessor.RunAsync();
                //await host.RunAsync();
            }
        }
    }
}