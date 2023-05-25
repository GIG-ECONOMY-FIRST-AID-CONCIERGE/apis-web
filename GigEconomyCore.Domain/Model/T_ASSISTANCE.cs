using GigEconomyCore.Domain.Entity;

namespace GigEconomyCore.Domain.Model
{
    public class T_ASSISTANCE
    {
        public int Id { get; set; }

        public int PartnerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string SinisterCircumstances { get; set; }
        public int Status { get; set; }

    }
}
