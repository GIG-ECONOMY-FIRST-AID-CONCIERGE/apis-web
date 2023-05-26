using GigEconomyCore.Domain.Enum;

namespace GigEconomyCore.Domain.Entity
{
    public class Vehicle 
    {
        public int Id { get; set; }
        public VehicleCategoy Category { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string ManufactureYear { get; set; }
        public string Chassi { get; set; }
        public int PartnerId { get; set; }  
    }
}
