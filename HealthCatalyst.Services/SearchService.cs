using HealthCatalyst.Interfaces.Repository;
using HealthCatalyst.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.Services
{
    /// <summary>
    /// Implementation of ISearchService
    /// </summary>
    public class SearchService
    {
        private readonly IReadRepository _readRepository;

        public SearchService(IReadRepository readRepository)
        {
            _readRepository = readRepository ?? throw new ArgumentNullException(nameof(readRepository));
        }

        public async Task<Person> Search(string term)
        {

        }
    }
}
