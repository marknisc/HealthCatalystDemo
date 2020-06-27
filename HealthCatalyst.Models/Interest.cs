namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of Interest
    /// </summary>
    public class Interest
    {
        public int InterestId { get; set; }
        public int? PersonId { get; set; }
        public string Description { get; set; }
    }
}
