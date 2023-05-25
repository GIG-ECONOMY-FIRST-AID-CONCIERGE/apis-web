namespace GigEconomyCore.Domain.Entity
{
    public class Sinister
    {
        public int Id { get; set; }
        public Partner Partner { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string SinisterCircumstances { get; set; }
        public string Status { get; set; }

    }
}
