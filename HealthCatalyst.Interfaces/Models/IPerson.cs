using System.Collections.Generic;

namespace HealthCatalyst.Interfaces.Models
{
    public interface IPerson
    {
        ICollection<Address> Addresses { get; set; }
        string GivenName { get; set; }
        ICollection<Interest> Interests { get; set; }
        int PersonId { get; set; }
        ICollection<Phone> Phones { get; set; }
        byte[] Photo { get; set; }
        string Surname { get; set; }
    }
}