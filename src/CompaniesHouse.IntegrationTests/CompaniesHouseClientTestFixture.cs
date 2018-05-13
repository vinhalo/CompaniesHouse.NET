using System.Threading.Tasks;
using NUnit.Framework;

namespace CompaniesHouse.IntegrationTests
{
    [TestFixture]
    public abstract class CompaniesHouseClientTestFixture
    {
        protected CompaniesHouseClient Client;

        [SetUp]
        public async Task Setup()
        {
            GivenACompaniesHouseClient();
            await When().ConfigureAwait(false);
        }

        protected abstract Task When();

        private void GivenACompaniesHouseClient()
        {
            var settings = new CompaniesHouseSettings(Keys.ApiKey);
            Client = new CompaniesHouseClient(settings);
        }
    }
}