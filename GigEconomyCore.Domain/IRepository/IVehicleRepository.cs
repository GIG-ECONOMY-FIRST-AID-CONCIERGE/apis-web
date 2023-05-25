using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IVehicleRepository
    {
        T_VEHICLE GetVehicleById(int Id);

        T_VEHICLE AddVehicle(T_VEHICLE vehicle);

        T_VEHICLE UpdateVehicle(T_VEHICLE vehicle);

        T_VEHICLE DeleteVehicle(T_VEHICLE vehicle);
    }
}
