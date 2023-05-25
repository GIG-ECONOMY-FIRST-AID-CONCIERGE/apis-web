using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Enum;

namespace GigEconomyCore.Domain.Model
{
    public class T_SINISTER
    {
        public int Id { get; set; }
        public int PartnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string SinisterCircumstances { get; set; }
        public string Status { get; set; }
    }
}
