using System.ComponentModel.DataAnnotations.Schema;

namespace GigEconomyCore.Domain.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CoordX { get; set; }
        public string CoordY { get; set; }
    }
}