using System.Collections.Generic;

namespace HealthCatalyst.Interfaces.Models
{
    public interface IPerson
    {
        ICollection<IAddress> Addresses { get; set; }
        string GivenName { get; set; }
        ICollection<IInterest> Interests { get; set; }
        int PersonId { get; set; }
        ICollection<IAndroid> Phones { get; set; }
        byte[] Photo { get; set; }
        string Surname { get; set; }
    }
}