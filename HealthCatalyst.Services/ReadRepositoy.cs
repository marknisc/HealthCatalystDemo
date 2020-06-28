using HealthCatalyst.Data;
using HealthCatalyst.Interfaces.Models;
using HealthCatalyst.Interfaces.Repository;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using System;
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
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IQueryable<IPerson>> Search(string term)
        {
            // Search for given name, surname and address line1 matches

            // Linq does translate StringComparision, so make term uppercase
            var upperTerm = term.ToUpper();

            try
            {
                var result1 = _searchCtx.Persons
                    // For simplicity of demo eagerly load navigation properties
                    // a more robust implementation would possibly use lazy loading
                    .Include("Phones")
                    .Include("Interests")
                    .Include("Addresses")
                    .Where(p => p.GivenName.ToUpper().Contains(upperTerm)
                    || p.Surname.ToUpper().Contains(upperTerm)
                    || p.Addresses.Any(a => a.Line1.ToUpper().Contains(upperTerm)));

                return result1;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                return null;
            }
        }
    }
}
