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
        Task<IQueryable<IPerson>> Search(string term);
    }
}
