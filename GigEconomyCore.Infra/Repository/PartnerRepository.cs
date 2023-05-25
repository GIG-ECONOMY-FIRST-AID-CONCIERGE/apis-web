using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Infra.Context;
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

        public T_PARTNER AddPartner(T_PARTNER partner)
        {
            _context.T_Partner.Add(partner);
            _context.SaveChanges();
            return partner;
        }

        public T_PARTNER DeletePartner(T_PARTNER partner)
        {
            throw new NotImplementedException();
        }

        public T_PARTNER GetPartnerById(int Id)
        {
            return _context.T_Partner.Where(p => p.Id == Id).FirstOrDefault();
        }

        public T_PARTNER GetPartnerByNationalId(string NationalId)
        {
            return _context.T_Partner.Where(p => p.Rg == NationalId).FirstOrDefault();
        }

        public T_PARTNER UpdatePartner(T_PARTNER partner)
        {
            throw new NotImplementedException();
        }
    }
}
