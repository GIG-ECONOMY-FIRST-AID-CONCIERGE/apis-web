using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Infra.Repository
{
    public class PartnerRepository : IPartnerRepository
    {
        private readonly DataContext _context;

        public PartnerRepository(DataContext _context)
        {
            this._context = _context;
        }

        public void AddPartner(T_PARTNER partner)
        {
            _context.T_Partner.Add(partner);
            _context.SaveChanges();
        }

        public void DeletePartner(T_PARTNER partner)
        {
            throw new NotImplementedException();
        }

        public T_PARTNER GetPartnerById(int Id)
        {
            return _context.T_Partner.Where(p => p.Id == Id).AsNoTracking().FirstOrDefault();
        }

        public T_PARTNER GetPartnerByNationalId(string NationalId)
        {
            return _context.T_Partner.Where(p => p.Cpf == NationalId).AsNoTracking().FirstOrDefault();
        }

        public void UpdatePartner(T_PARTNER partner)
        {
            _context.T_Partner.Update(partner);
            _context.SaveChanges();
        }
    }
}
