using HealthCatalyst.Interfaces.Models;

namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of <see cref="IInterest"/>
    /// </summary>
    public class Interest : IInterest
    {
        public int InterestId { get; set; }
        public int? PersonId { get; set; }
        public string Description { get; set; }
    }
}
