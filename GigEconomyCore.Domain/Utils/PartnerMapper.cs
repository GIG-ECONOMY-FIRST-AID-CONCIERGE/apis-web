using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Utils
{
    public class PartnerMapper
    {
        private readonly Partner partner;

        public PartnerMapper(Partner partner)
        {
            this.partner = partner;
        }

        public T_PARTNER Convert()
        {
            T_PARTNER t_partner = new T_PARTNER();

            t_partner.Id = partner.Id;
            t_partner.Name = partner.Name;
            t_partner.Cpf = partner.Cpf;
            t_partner.BirthDate = partner.BirthDate;
            t_partner.Rg = partner.Rg;

            return t_partner;
        }
    }
}
