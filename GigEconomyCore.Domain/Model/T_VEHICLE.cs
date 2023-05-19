using GigEconomyCore.Domain.Entity;

namespace GigEconomyCore.Domain.Model
{
    public class T_VEHICLE
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string ManufactureYear { get; set; }
        public string VehicleId { get; set; }
        public string Chassi { get; set; }
    }
}
