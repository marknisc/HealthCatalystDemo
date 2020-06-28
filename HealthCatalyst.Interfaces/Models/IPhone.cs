namespace HealthCatalyst.Interfaces.Models
{
    /// <summary>
    /// Definition of IPhone
    /// </summary>
    public interface IPhone
    {
        long Number { get; set; }
        int? PersonId { get; set; }
        int PhoneId { get; set; }
        PhoneType Type { get; set; }
    }
}