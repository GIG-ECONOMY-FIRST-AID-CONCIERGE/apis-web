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
    public class SinisterRepository : ISinisterRepository
    {
        private readonly DataContext _context;

        public SinisterRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_SINISTER AddSinister(T_SINISTER sinister)
        {
            _context.T_Sinister.Add(sinister);
            _context.SaveChanges();
            return sinister;
        }

        public T_SINISTER DeleteSinister(T_SINISTER sinister)
        {
            throw new NotImplementedException();
        }

        public T_SINISTER GetSinisterById(int Id)
        {
            return _context.T_Sinister.Where(p => p.Id == Id).FirstOrDefault();
        }

        public T_SINISTER UpdateSinister(T_SINISTER sinister)
        {
            throw new NotImplementedException();
        }
    }
}
