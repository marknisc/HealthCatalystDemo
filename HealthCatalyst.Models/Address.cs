namespace HealthCatalyst.Models
{
    /// <summary>
    /// Implementation of Address
    /// 
    /// For simplicity of demo assume US address
    /// </summary>
    public class Address
    {
        public int AddressId { get; set; }
        public int? PersonId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
}
