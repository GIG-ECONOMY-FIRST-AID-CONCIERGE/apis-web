using GigEconomyCore.Domain.Entity;

namespace GigEconomyCore.Domain.Model
{
    public class T_ASSISTANCE
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string SinisterCircumstances { get; set; }
        public string Status { get; set; }       
    }
}
