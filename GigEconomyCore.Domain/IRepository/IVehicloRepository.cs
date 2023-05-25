using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IVehicloRepository
    {
        T_VEHICLE GetVehicloById(int Id);

        T_VEHICLE AddVehiclo(T_VEHICLE vehiclo);

        T_VEHICLE UpdateVehiclo(T_VEHICLE vehiclo);

        T_VEHICLE DeleteVehiclo(T_VEHICLE vehiclo);
    }
}
