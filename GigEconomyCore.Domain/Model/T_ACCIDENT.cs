using GigEconomyCore.Domain.Entity;

namespace GigEconomyCore.Domain.Model
{
    public class T_ACCIDENT
    {
        public int Id { get; set; }
        public int IdSinistro { get; set; }
        public int IdAdress { get; set; }
        public int IdPartner { get; set; }
        public int IdVehicle { get; set; }
        public string Status { get; set; }
        
    }
}
