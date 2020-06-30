
using HealthCatalyst.Services;

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

using Xunit;

namespace HealthCatalyst.UnitTests
{
    public class SearchServiceTests
    {
        [Fact]
        public void SearchService_SearchTerm()
        {
            var repo = new ReadRepository(Logger);
            var sut = new SearchService(repo, Logger);

            var results = sut.Search("walnut");
        }

        #region Properties

        private ILogger Logger { get; set; } = NullLogger.Instance;

        #endregion
    }
}
