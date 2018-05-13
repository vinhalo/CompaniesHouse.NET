using System;

namespace CompaniesHouse
{
    public class CompaniesHouseSettings : ICompaniesHouseSettings
    {

        public CompaniesHouseSettings(Uri baseUri, Uri documentBaseUri, string apiKey)
        {
            BaseUri = baseUri;
            DocumentBaseUri = documentBaseUri;
            ApiKey = apiKey;
        }

        public CompaniesHouseSettings(string apiKey)
            :this(CompaniesHouseUris.Default, CompaniesHouseDocumentUris.Default, apiKey)
        {
        }

        public Uri BaseUri { get; }

        public Uri DocumentBaseUri { get; }

        public string ApiKey { get; }
    }
}