using GigEconomyCore.Domain.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace GigEconomyCore.Domain.Model
{
    public class T_ADDRESS
    {
        public int Id { get; set; }
        public int? PartnerId { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? CoordX { get; set; }
        public string? CoordY { get; set; }
    }
}
