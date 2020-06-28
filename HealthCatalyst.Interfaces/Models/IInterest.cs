namespace HealthCatalyst.Interfaces.Models
{
    /// <summary>
    /// Definition of IInterest
    /// </summary>
    public interface IInterest
    {
        string Description { get; set; }
        int InterestId { get; set; }
        int? PersonId { get; set; }
    }
}