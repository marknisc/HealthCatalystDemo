namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of Phone
    /// </summary>
    public class Phone
    {
        public int PhoneId { get; set; }
        public int? PersonId { get; set; }
        public long Number { get; set; }
        public PhoneType Type { get; set; }
    }
}
