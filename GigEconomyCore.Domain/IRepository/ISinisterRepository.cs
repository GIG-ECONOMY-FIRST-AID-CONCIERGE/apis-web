using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface ISinisterRepository
    {
        T_SINISTER GetSinisterById(int Id);

        T_SINISTER AddSinister(T_SINISTER sinister);

        T_SINISTER UpdateSinister(T_SINISTER sinister);

        T_SINISTER DeleteSinister(T_SINISTER sinister);
    }
}
