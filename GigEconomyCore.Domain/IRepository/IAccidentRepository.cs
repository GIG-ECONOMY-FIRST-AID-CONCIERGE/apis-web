using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IAccidentRepository
    {
        T_ACCIDENT GetAccidentById(int Id);

        List<T_ACCIDENT> GetAccidentByStatus(string status);

        T_ACCIDENT AddAccident(T_ACCIDENT accident);

        T_ACCIDENT UpdateAccident(T_ACCIDENT accident);

        T_ACCIDENT DeleteAccident(T_ACCIDENT accident);
    }
}
