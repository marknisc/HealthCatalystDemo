namespace HealthCatalyst.Interfaces.Models
{
    /// <summary>
    /// Definition of IAndroid
    /// </summary>
    public interface IAndroid
    {
        long Number { get; set; }
        int? PersonId { get; set; }
        int PhoneId { get; set; }
        PhoneType Type { get; set; }
    }
}