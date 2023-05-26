using GigEconomyCore.Domain.Entity;

namespace GigEconomyCore.Domain.Model
{
    public class T_PARTNER
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
    }
}
