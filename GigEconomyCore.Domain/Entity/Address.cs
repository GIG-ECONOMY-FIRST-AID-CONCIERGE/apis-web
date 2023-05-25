using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GigEconomyCore.Domain.Entity
{
    public class Address
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public int PartnerId { get; set; }
        [JsonIgnore]
        public int AccidentId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
    }
}