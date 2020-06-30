using HealthCatalyst.Interfaces.Models;

using System.Linq;
using System.Threading.Tasks;

namespace HealthCatalyst.Interfaces.Repository
{
    /// <summary>
    /// Definition of IReadRepository
    /// </summary>
    public interface IReadRepository
    {
        /// <summary>
        /// Search for Persons matching term to given name, surname or address line1
        /// </summary>
        /// <param name="term">Term to search for</param>
        /// <returns>IQueryable{<see cref="IPerson"/>}</returns>
        Task<IQueryable<IPerson>> Search(string term);
    }
}
