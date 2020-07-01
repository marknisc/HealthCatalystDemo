
using HealthCatalyst.Interfaces.Models;

using System.Collections.Generic;

namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of <see cref="IPerson"/>
    /// </summary>
    public class Person : IPerson
    {
        public int PersonId { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public ICollection<IAndroid> Phones { get; set; }
        public ICollection<IAddress> Addresses { get; set; }
        public ICollection<IInterest> Interests { get; set; }
        public byte[] Photo { get; set; }
    }
}
