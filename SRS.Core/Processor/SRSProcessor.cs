using Library.ApiClients.Interface;
using Library.Logger;
using SRS.Core.Interfaces;
using SRS.Core.Repositories;
using SRS.Core.Utils;
using System.ComponentModel.Design;

namespace SRS.Core.Processor
{
    public class SRSProcessor : ISRSProcessor
    {
        private readonly IDistributorRepository distributorRepository;
        private readonly ISRSService sRSService;
        private readonly MyLogger myLogger;
        private readonly ICompanySettingsRepository companySettingsRepository;
        private readonly ICompanySettingClient companySettingClient;

        public SRSProcessor(IDistributorRepository distributorRepository,
            ISRSService sRSService, MyLogger myLogger,
            ICompanySettingsRepository companySettingsRepository,
            ICompanySettingClient companySettingClient)
        {
            this.distributorRepository = distributorRepository;
            this.sRSService = sRSService;
            this.myLogger = myLogger;
            this.companySettingsRepository = companySettingsRepository;
            this.companySettingClient = companySettingClient;
        }

        public async Task RunAsync()
        {
            Console.WriteLine($"--------------------");
            Console.WriteLine("Starting SRS Service");
            Console.WriteLine($"--------------------");

            var companiesUsingDMS = await companySettingsRepository.GetAllCompaniesUsingOnlineDMS();

            foreach (var company in companiesUsingDMS)
            {
                var usesSRS = (await companySettingClient.GetCompanySetting(company.CompanyId)).
                CompanyUsesSrs;
                if (usesSRS)
                {
                    Console.WriteLine("Running it for: " + company.CompanyId);
                    await GenerateSRSOrdersForCompany(company.CompanyId);
                }
            }

            Console.WriteLine($"--------------------");
            Console.WriteLine("Ending SRS Service");
            Console.WriteLine($"--------------------");

        }

        private async Task GenerateSRSOrdersForCompany(long companyId)
        {
            var companyDistributors = await distributorRepository.GetDistributors(companyId);
            foreach (var distributor in companyDistributors)
            {
                await sRSService.GenerateSrsOrder(distributorId: distributor.Id,
                    companyId: companyId,
                    dateRange: new DateRange(fromDate: DateTime.UtcNow.AddMonths(-3),
                    toDate: DateTime.UtcNow),
                    frequency: 7);
            }
        }
    }
}
