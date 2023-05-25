using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IAssistanceRepository
    {
        T_ASSISTANCE GetAssistanceById(int Id);
        List<T_ASSISTANCE> GetAssistanceByPartnerId(int Id);
        T_ASSISTANCE AddAssistance(T_ASSISTANCE assistance);

        T_ASSISTANCE UpdateAssistance(T_ASSISTANCE assistance);

        T_ASSISTANCE DeleteAssistance(T_ASSISTANCE assistance);
    }
}
