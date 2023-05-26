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
    public class VehicleRepository : IVehicleRepository
    {
        private readonly DataContext _context;

        public VehicleRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_VEHICLE AddVehicle(T_VEHICLE vehicle)
        {
            _context.T_Vehiclo.Add(vehicle);
            _context.SaveChanges();
            return vehicle;
        }

        public T_VEHICLE DeleteVehicle(T_VEHICLE vehicle)
        {
            throw new NotImplementedException();
        }

        public T_VEHICLE GetVehicleById(int Id)
        {
            return _context.T_Vehiclo.Where(p => p.Id == Id).FirstOrDefault();
        }
        public T_VEHICLE GetVehicleByPartnerId(int id)
        {
            return _context.T_Vehiclo.Where(p => p.PartnerId == id).FirstOrDefault();
        }

        public T_VEHICLE UpdateVehicle(T_VEHICLE vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
