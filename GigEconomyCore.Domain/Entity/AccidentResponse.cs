using GigEconomyCore.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Entity
{
    public class AccidentResponse
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public Partner Partner { get; set; }
        public List<Assistance> Assistances { get; set; }
        public AccidentStatus Status { get; set; }

        public DateTime OccurredDate { get; set; }
        public bool RepliedNotification { get; set; }

        public AccidentResponse()
        {
            this.Assistances = new List<Assistance>();
        }
    }
}
