using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using System;

namespace SRS.MSTest.Configurations
{
    public static class Configuration
    {
        public static IConfiguration GetConfiguration()
        {
            var env = Environment.GetEnvironmentVariable("BuildEnvironment");
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            var keyVaultEndpoint = Environment.GetEnvironmentVariable("KEYVAULT_ENDPOINT");
            if (!string.IsNullOrEmpty(keyVaultEndpoint))
            {
                var azureServiceTokenProvider = new AzureServiceTokenProvider();
                var keyVaultClient = new KeyVaultClient(
                    new KeyVaultClient.AuthenticationCallback(
                        azureServiceTokenProvider.KeyVaultTokenCallback));
                configBuilder.AddAzureKeyVault(
                    keyVaultEndpoint, keyVaultClient, new DefaultKeyVaultSecretManager());
            }
            return configBuilder.Build();
        }
    }
}
