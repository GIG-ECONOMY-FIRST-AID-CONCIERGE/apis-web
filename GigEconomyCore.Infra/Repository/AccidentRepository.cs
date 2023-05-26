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
    public class AccidentRepository : IAccidentRepository
    {
        private readonly DataContext _context;

        public AccidentRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_ACCIDENT AddAccident(T_ACCIDENT accident)
        {
            _context.T_Accident.Add(accident);
            _context.SaveChanges();
            return accident;
        }

        public T_ACCIDENT DeleteAccident(T_ACCIDENT assistence)
        {
            throw new NotImplementedException();
        }

        public T_ACCIDENT GetAccidentById(int Id)
        {
            return _context.T_Accident.Where(p => p.Id == Id).FirstOrDefault();
        }

        public List<T_ACCIDENT> GetAccidentByStatus(int status)
        {
            return _context.T_Accident.Where(p => p.Status == status).ToList();
        }

        public List<T_ACCIDENT> GetAccidentByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public T_ACCIDENT UpdateAccident(T_ACCIDENT accident)
        {
            _context.T_Accident.Update(accident);
            _context.SaveChanges();
            return accident;
        }
    }
}
