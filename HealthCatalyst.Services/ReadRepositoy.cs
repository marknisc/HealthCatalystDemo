using HealthCatalyst.Data;
using HealthCatalyst.Interfaces.Repository;
using HealthCatalyst.Models;

using Microsoft.Extensions.Logging;

using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalyst.Services
{
    /// <summary>
    /// Implementation of <see cref="IReadRepository"/>
    /// </summary>
    public class ReadRepositoy : IReadRepository
    {
        private readonly ILogger _logger;
        SearchContext _searchCtx = new SearchContext();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">Implementation of <see cref="ILogger"/></param>
        public ReadRepositoy(ILogger logger)
        {
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }

        public async Task<IQueryable<Person>> Search(string term)
        {
            // Search for given name, surname and address line1 matches

            var result1 = _searchCtx.Persons
                .Where(p => p.GivenName.Contains(term)
                || p.Surname.Contains(term)
                || p.Addresses.Any(a => a.Line1.Contains(term)));

            return result1;
        }
    }
}
