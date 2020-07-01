namespace HealthCatalyst.Interfaces.Models
{
    /// <summary>
    /// Definition of IAddress
    /// </summary>
    public interface IAddress
    {
        int AddressId { get; set; }
        string City { get; set; }
        string Line1 { get; set; }
        string Line2 { get; set; }
        int? PersonId { get; set; }
        string PostalCode { get; set; }
        string State { get; set; }
    }
}