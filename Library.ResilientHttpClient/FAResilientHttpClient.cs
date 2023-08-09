using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ResilientHttpClient
{
    public class FAResilientHttpClient
    {
        private HttpClient httpClient;
        private IEnumerable<HttpStatusCode> httpCodesToRetry;
        private int noOfRetries = 3;
        private double maxWaitDurationSeconds = 30;
        private static IEnumerable<HttpStatusCode> defaultStatusCodesToRetry =
            new List<HttpStatusCode> {
                HttpStatusCode.GatewayTimeout,
                HttpStatusCode.InternalServerError,
                HttpStatusCode.RequestTimeout
                };

        public HttpRequestHeaders DefaultRequestHeaders => httpClient.DefaultRequestHeaders;

        public FAResilientHttpClient(int noOfRetries = 3, TimeSpan? maxWaitDuration = null)
                : this(defaultStatusCodesToRetry, noOfRetries, maxWaitDuration)
        {
        }
        public FAResilientHttpClient(IEnumerable<HttpStatusCode> httpCodesToRetry, int noOfRetries = 3, TimeSpan? maxWaitDuration = null)
        {
            httpClient = new HttpClient();
            this.httpCodesToRetry = httpCodesToRetry;
            this.noOfRetries = noOfRetries <= 0 ? 1 : noOfRetries;
            maxWaitDurationSeconds = maxWaitDuration?.TotalSeconds ?? 30;
        }

        private async Task DelayNextAttempt(int attemptNo)
        {
            await Task.Delay(TimeSpan.FromSeconds((attemptNo + 1) * (maxWaitDurationSeconds / noOfRetries)));
        }
        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent httpContent)
        {
            return await PostAsync(requestUri, httpContent, 0);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent httpContent)
        {
            return await PutAsync(requestUri, httpContent, 0);
        }

        public async Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent httpContent)
        {
            var request = new HttpRequestMessage(new HttpMethod("PUT"), requestUri);
            //request.Content = httpContent;

            var response = await httpClient.SendAsync(request);
            return response;
        }

        private async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent httpContent, int retryCount)
        {
            HttpResponseMessage response;
            try
            {
                response = await httpClient.PutAsync(requestUri, httpContent);
                if (httpCodesToRetry.Contains(response.StatusCode))
                {

                    if (retryCount < noOfRetries)
                    {
                        await DelayNextAttempt(retryCount);
                        return await PutAsync(requestUri, httpContent, ++retryCount);
                    }
                }
            }
            catch (Exception)
            {
                if (retryCount < noOfRetries)
                {
                    await DelayNextAttempt(retryCount);
                    return await PutAsync(requestUri, httpContent, ++retryCount);
                }
                else
                {
                    throw;
                }
            }
            return response;
        }

        private async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent httpContent, int retryCount)
        {
            HttpResponseMessage response;
            try
            {
                response = await httpClient.PostAsync(requestUri, httpContent);
                if (httpCodesToRetry.Contains(response.StatusCode))
                {

                    if (retryCount < noOfRetries)
                    {
                        await DelayNextAttempt(retryCount);
                        return await PostAsync(requestUri, httpContent, ++retryCount);
                    }
                }
            }
            catch (Exception)
            {
                if (retryCount < noOfRetries)
                {
                    await DelayNextAttempt(retryCount);
                    return await PostAsync(requestUri, httpContent, ++retryCount);
                }
                else
                {
                    throw;
                }
            }
            return response;
        }
        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await GetAsync(requestUri, 0);
        }
        private async Task<HttpResponseMessage> GetAsync(string requestUri, int retryCount)
        {
            HttpResponseMessage response;
            try
            {
                response = await httpClient.GetAsync(requestUri);
                if (httpCodesToRetry.Contains(response.StatusCode))
                {

                    if (retryCount < noOfRetries)
                    {
                        await DelayNextAttempt(retryCount);
                        return await GetAsync(requestUri, ++retryCount);
                    }
                }
            }
            catch (Exception ex)
            {
                if (retryCount < noOfRetries)
                {
                    await DelayNextAttempt(retryCount);
                    return await GetAsync(requestUri, ++retryCount);
                }
                else
                {
                    throw new Exception($"Failed While Accessing: {requestUri}", ex);
                }
            }
            return response;
        }
    }
}
