using HealthCatalyst.Interfaces.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthCatalyst.Interfaces.Services
{
    /// <summary>
    /// Definition of ISearchService
    /// </summary>
    public interface ISearchService
    {
        /// <summary>
        /// Search for persons matching given search term
        /// </summary>
        /// <param name="term">Term to search for</param>
        /// <returns>ICollection{IPerson}</returns>
        Task<ICollection<IPerson>> Search(string term);
    }
}