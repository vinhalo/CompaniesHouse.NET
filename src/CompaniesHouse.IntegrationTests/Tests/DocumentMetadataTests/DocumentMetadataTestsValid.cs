using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CompaniesHouse.Response.DocumentMetadata;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests.Tests.DocumentMetadataTests
{
    public class DocumentMetadataTestsValid : CompaniesHouseClientTestFixture
    {
        private CompaniesHouseClientResponse<DocumentMetadata> _result;

        protected override async Task When()
        {
            _result = await Client.GetDocumentMetadataAsync("YoQVnmW1Vrz1ndERnATp1gmvEBsHJt2SCFk0xpitiwU",
                CancellationToken.None);
        }

        [Test]
        public void ThenDataIsReturned()
        {
            Assert.That(_result.Data, Is.Not.Null);
        }
    }
}
