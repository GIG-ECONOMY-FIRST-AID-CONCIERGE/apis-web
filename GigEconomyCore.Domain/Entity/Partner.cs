using System.Text.Json.Serialization;

namespace GigEconomyCore.Domain.Entity
{
    public class Partner
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Address? Address { get; set; }
        public string Phone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}
