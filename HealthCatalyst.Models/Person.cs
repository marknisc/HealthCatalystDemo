
using System.Collections.Generic;

namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of Person
    /// </summary>
    public class Person
    {
        public int PersonId { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Interest> Interests { get; set; }
        public byte[] Photo { get; set; }
    }
}
