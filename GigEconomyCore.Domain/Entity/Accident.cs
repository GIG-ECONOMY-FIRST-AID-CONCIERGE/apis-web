using GigEconomyCore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Entity
{
    public class Accident
    {
        public Sinister Sinistro { get; set; }
        public Address Adress { get; set; }
        public Partner Partner { get; set; }
        public Vehicle Vehicle { get; set; }
        public List<Assistance> Assistances { get; set; }
        public AccidentStatus Status { get; set; }

        public Accident()
        {
            this.Assistances = new List<Assistance>();
        }
    }
}
