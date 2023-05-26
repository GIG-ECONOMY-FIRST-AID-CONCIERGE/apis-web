using GigEconomyCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Command
{
    public class PartnerPostCommand
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Address? Address { get; set; }
        public string Phone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
    }
}
