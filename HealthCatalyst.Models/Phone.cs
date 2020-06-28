using HealthCatalyst.Interfaces.Models;

namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of <see cref="IPhone"/>
    /// </summary>
    public class Phone : IPhone
    {
        public int PhoneId { get; set; }
        public int? PersonId { get; set; }
        public long Number { get; set; }
        public PhoneType Type { get; set; }
    }
}
