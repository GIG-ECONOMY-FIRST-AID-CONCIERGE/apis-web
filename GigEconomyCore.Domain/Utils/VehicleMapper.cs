using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Enum;
using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Utils
{
    public class VehicleMapper
    {
        
        public T_VEHICLE Convert(Vehicle vehicle)
        {
            T_VEHICLE t_vehicle = new T_VEHICLE();

            t_vehicle.Id = vehicle.Id;
            t_vehicle.Model = vehicle.Model;
            t_vehicle.Manufacturer = vehicle.Manufacturer;
            t_vehicle.ManufactureYear = vehicle.ManufactureYear;
            t_vehicle.PartnerId = vehicle.PartnerId;
            t_vehicle.Category = vehicle.Category.ToString();
            t_vehicle.Chassi = vehicle.Chassi;

            return t_vehicle;
        }

        public Vehicle Convert(T_VEHICLE t_vehicle)
        {
            Vehicle vehicle = new Vehicle();

            vehicle.Id = t_vehicle.Id;
            vehicle.Model = t_vehicle.Model;
            vehicle.Manufacturer = t_vehicle.Manufacturer;
            vehicle.ManufactureYear = t_vehicle.ManufactureYear;
            vehicle.PartnerId = t_vehicle.PartnerId;
            vehicle.Category = t_vehicle.Category.Equals("Motorbike") ? (VehicleCategoy)1 : (VehicleCategoy)2;
            vehicle.Chassi = t_vehicle.Chassi;

            return vehicle;
        }
    }
}
