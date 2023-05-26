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
        
        public T_PARTNER Convert(Partner partner)
        {
            T_PARTNER t_partner = new T_PARTNER();

            t_partner.Id = partner.Id;
            t_partner.Name = partner.Name;
            t_partner.Cpf = partner.Cpf;
            t_partner.BirthDate = partner.BirthDate;
            t_partner.Rg = partner.Rg;

            return t_partner;
        }

        public Partner Convert(T_PARTNER t_partner)
        {
            Partner partner = new Partner();

            partner.Id = t_partner.Id;
            partner.Name = t_partner.Name;
            partner.Cpf = t_partner.Cpf;
            partner.BirthDate = t_partner.BirthDate;
            partner.Rg = t_partner.Rg;

            return partner;
        }
    }
}
