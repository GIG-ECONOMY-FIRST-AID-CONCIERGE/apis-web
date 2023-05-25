using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Enum;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Infra.Repository
{
    public class VehicloRepository : IVehicloRepository
    {
        private readonly DataContext _context;

        public VehicloRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_VEHICLE AddVehiclo(T_VEHICLE vehicle)
        {
            _context.T_Vehicle.Add(vehicle);
            _context.SaveChanges();
            return vehicle;
        }

        public T_VEHICLE DeleteVehiclo(T_VEHICLE vehiclo)
        {
            throw new NotImplementedException();
        }

        public T_VEHICLE GetVehicloById(int Id)
        {
            return _context.T_Vehicle.Where(p => p.Id == Id).FirstOrDefault();
        }

        public T_VEHICLE UpdateVehiclo(T_VEHICLE vehiclo)
        {
            throw new NotImplementedException();
        }
    }
}
