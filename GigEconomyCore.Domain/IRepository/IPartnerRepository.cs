using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IPartnerRepository
    {
        T_PARTNER GetPartnerById(int Id);

        T_PARTNER GetPartnerByNationalId(string nationalId);

        void AddPartner(T_PARTNER partner);

        void UpdatePartner(T_PARTNER partner);

        void DeletePartner(T_PARTNER partner);
    }
}
