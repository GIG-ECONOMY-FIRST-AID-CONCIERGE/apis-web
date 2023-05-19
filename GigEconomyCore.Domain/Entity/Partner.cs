namespace GigEconomyCore.Domain.Entity
{
    public class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Address Address { get; set; }
        public Phone Phone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}
