using System;

namespace CompaniesHouse.UriBuilders
{
    public interface IDocumentMetadataUriBuilder
    {
        Uri Build(string documentId);
    }
}