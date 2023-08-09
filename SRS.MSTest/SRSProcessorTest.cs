using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRS.Core.Interfaces;
using SRS.Processor;

namespace SRS.MSTest
{
    [TestClass]
    public class SRSProcessorTest
    {
        private  IServiceProvider serviceProvider;

        [TestInitialize]
        public void Initialise()
        {
            //Environment.SetEnvironmentVariable("KEYVAULT_ENDPOINT", "https://DMSManageReadOnly.vault.azure.net/");
            Environment.SetEnvironmentVariable("KEYVAULT_ENDPOINT", "https://DMSDebugWritable.vault.azure.net/");
            var configuration = Configurations.Configuration.GetConfiguration();

            IServiceCollection serviceCollection = new ServiceCollection();

            Dependencies.SetUp(serviceCollection, configuration);
            serviceProvider = serviceCollection.BuildServiceProvider();
        }

        [TestMethod]
        public async Task Test_SRSProcessor_And_Check_If_It_Runs()
        {
            var srsProcessor = serviceProvider.GetRequiredService<ISRSProcessor>();
            await srsProcessor.RunAsync();
        }
    }
}