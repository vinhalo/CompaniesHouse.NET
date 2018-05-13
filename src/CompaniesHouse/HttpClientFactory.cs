using System;
using System.Net;
using System.Net.Http;
using CompaniesHouse.DelegatingHandlers;

namespace CompaniesHouse
{
    public class CompaniesHouseDocumentHttpClientFactory : HttpClientFactory
    {
        public CompaniesHouseDocumentHttpClientFactory(ICompaniesHouseSettings settings) : base(settings)
        {
        }

        protected override Uri GetBaseUri()
        {
            return Settings.DocumentBaseUri;
        }
    }

    public class CompaniesHouseHttpClientFactory : HttpClientFactory
    {
        public CompaniesHouseHttpClientFactory(ICompaniesHouseSettings settings) : base(settings)
        {
        }

        protected override Uri GetBaseUri()
        {
            return Settings.BaseUri;
        }
    }

    public abstract class HttpClientFactory : IHttpClientFactory
    {
        protected readonly ICompaniesHouseSettings Settings;

        protected HttpClientFactory(ICompaniesHouseSettings settings)
        {
            Settings = settings;
        }

        public HttpClient CreateHttpClient()
        {
            var httpClientHandler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var companiesHouseAuthorizationHandler = new CompaniesHouseAuthorizationHandler(Settings.ApiKey)
            {
                InnerHandler = httpClientHandler
            };

            var httpClient = new HttpClient(companiesHouseAuthorizationHandler)
            {
                BaseAddress = GetBaseUri()
            };


            return httpClient;
        }

        protected abstract Uri GetBaseUri();
    }
}