using System;

namespace CompaniesHouse
{
    public interface ICompaniesHouseSettings
    {
        Uri BaseUri { get; }

        Uri DocumentBaseUri { get; }

        string ApiKey { get; }
    }
}