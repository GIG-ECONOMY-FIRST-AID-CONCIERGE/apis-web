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
        public int Id { get; set; }
        public Address Address { get; set; }
        public int PartnerId { get; set; }
        public List<Assistance> Assistances { get; set; }

        public bool RepliedNotification { get; set; }


        public Accident()
        {
            this.Assistances = new List<Assistance>();
        }
    }
}
