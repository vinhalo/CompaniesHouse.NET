using System;

namespace CompaniesHouse.UriBuilders
{
    public class DocumentMetadataUriBuilder : IDocumentMetadataUriBuilder
    {
        public Uri Build(string documentId)
        {
            var path = "document/" + Uri.EscapeDataString(documentId);

            return new Uri(path, UriKind.Relative);
        }
    }
}