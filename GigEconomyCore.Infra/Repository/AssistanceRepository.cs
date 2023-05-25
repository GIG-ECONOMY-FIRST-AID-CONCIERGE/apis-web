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
    public class AssistanceRepository : IAssistanceRepository
    {
        private readonly DataContext _context;

        public AssistanceRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_ASSISTANCE AddAssistance(T_ASSISTANCE assistence)
        {
            _context.T_Assistance.Add(assistence);
            _context.SaveChanges();
            return assistence;
        }

        public T_ASSISTANCE DeleteAssistance(T_ASSISTANCE assistence)
        {
            throw new NotImplementedException();
        }

        public T_ASSISTANCE GetAssistanceById(int Id)
        {
            return _context.T_Assistance.Where(p => p.Id == Id).FirstOrDefault();
        }

        public List<T_ASSISTANCE> GetAssistanceByPartnerId(int Id)
        {
            return _context.T_Assistance.Where(p => p.PartnerId == Id).ToList();
        }

        public T_ASSISTANCE UpdateAssistance(T_ASSISTANCE assistence)
        {
            throw new NotImplementedException();
        }
    }
}
