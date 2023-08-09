using Library.ApiClients.Interface;
using Library.ApiClients.Models;
using Newtonsoft.Json;
using ResilientHttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ApiClients.Implementation
{
    public class CompanySettingClient : FAResilientHttpClient, ICompanySettingClient
    {
        //private readonly HttpClient httpClient;
        private readonly CompanyConfigSettings appConfigSettings;

        public CompanySettingClient(CompanyConfigSettings
            appConfigSettings) : base(1)
        {
            //this.httpClient = httpClient;
            this.appConfigSettings = appConfigSettings;
            string basicAuth = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{appConfigSettings.CompanySettingUsername}" + ":" + $"{appConfigSettings.CompanySettingPassword}"));
            base.DefaultRequestHeaders.Add($"Authorization", "Basic " + $"{basicAuth}");
            //httpClient.BaseAddress = new Uri(appConfigSettings.CompanySettingBaseUrl);

            //httpClient.DefaultRequestHeaders.Accept.Add(
            //                  new MediaTypeWithQualityHeaderValue("application/json"));

            //httpClient.DefaultRequestHeaders.Authorization = new
            //    AuthenticationHeaderValue("Bearer", appConfigSettings.reportApiToken);
        }

        public async Task<CompanySettingModel> GetCompanySetting(long companyId)
        {
            var dataUrl = $"{appConfigSettings.CompanySettingBaseUrl}/api/v1/company-setting/" + companyId;
            var data = await GetAsync(dataUrl);
            data.EnsureSuccessStatusCode();
            var output = await data.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CompanySettingModel>(output);
        }
    }
}
