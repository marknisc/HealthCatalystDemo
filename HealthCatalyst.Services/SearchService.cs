using HealthCatalyst.Interfaces.Models;
using HealthCatalyst.Interfaces.Repository;
using HealthCatalyst.Interfaces.Services;

using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalyst.Services
{
    /// <summary>
    /// Implementation of ISearchService
    /// </summary>
    public class SearchService : ISearchService
    {
        private readonly IReadRepository _readRepository;
        private readonly ILogger _logger;

        public SearchService(IReadRepository readRepository, ILogger logger)
        {
            _readRepository = readRepository ?? throw new ArgumentNullException(nameof(readRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <inheritdoc/>
        public async Task<ICollection<IPerson>> Search(string term)
        {
            ICollection<IPerson> persons = new List<IPerson>();

            try
            {
                persons = (await _readRepository.Search(term)).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }

            return persons;
        }
    }
}
