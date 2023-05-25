using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IPartnerRepository
    {
        T_PARTNER GetPartnerById(int Id);

        T_PARTNER AddPartner(T_PARTNER partner);

        T_PARTNER UpdatePartner(T_PARTNER partner);

        T_PARTNER DeletePartner(T_PARTNER partner);
    }
}
