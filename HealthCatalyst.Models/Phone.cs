using HealthCatalyst.Interfaces.Models;

namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of <see cref="IAndroid"/>
    /// </summary>
    public class Phone : IAndroid
    {
        public int PhoneId { get; set; }
        public int? PersonId { get; set; }
        public long Number { get; set; }
        public PhoneType Type { get; set; }
    }
}
