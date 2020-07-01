using HealthCatalyst.Interfaces.Models;
using HealthCatalyst.Interfaces.Services;
using HealthCatalyst.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalyst.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;
        private readonly ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="searchService">Implementation of <see cref="ISearchService"/></param>
        /// <param name="logger">Implementation of <see cref="ILogger"/></param>
        public SearchController(ISearchService searchService, ILogger<SearchController> logger)
        {
            _searchService = searchService ?? throw new System.ArgumentNullException(nameof(searchService));
            _logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public async Task<ICollection<IPerson>> Get([FromQuery(Name = "term")] string term)
        {
            if(string.IsNullOrWhiteSpace(term))
            {
                _logger.LogInformation("No search term provided");
                return new List<IPerson>();
            }

            return (await _searchService.Search(term)).ToList();
        }
    }
}
