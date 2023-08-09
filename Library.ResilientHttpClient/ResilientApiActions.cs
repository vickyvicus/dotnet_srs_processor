using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ResilientHttpClient
{
    public class ResilientAPIActions
    {
        private readonly HttpClient _client;

        public ResilientAPIActions(string bearerToken = null, int? timeout = null)
        {
            _client = new HttpClient();
            if (timeout.HasValue)
            {
                _client.Timeout = TimeSpan.FromSeconds(timeout.Value);
            }
            if (bearerToken != null)
            {
                _client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", bearerToken);
            }
        }

        public async Task<List<T>> GetList<T>(string api, int retryCount = 0)
        {
            HttpResponseMessage response;
            do
            {
                response = await _client.GetAsync(api).ConfigureAwait(false);
                string responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var data = JsonConvert.DeserializeObject<List<T>>(responseBody);
                    return data;
                }
                retryCount--;
                await Task.Delay(3000);
            } while (retryCount >= 0);
            string errorBody = await response.Content.ReadAsStringAsync();
            throw new Exception($"Dependency Failed to respond Properly at {api}", new Exception(errorBody));
        }

        public async Task<T> Get<T>(string api, int retryCount = 0)
        {
            HttpResponseMessage response;
            do
            {
                response = await _client.GetAsync(api).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T>(responseBody);
                    return data;
                }
                retryCount--;
                await Task.Delay(3000);
            } while (retryCount >= 0);

            string errorBody = await response.Content.ReadAsStringAsync();
            throw new Exception($"Dependency Failed to respond Properly at {api}", new Exception(errorBody));
        }
    }

}
