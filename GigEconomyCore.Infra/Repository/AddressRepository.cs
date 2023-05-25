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
    public class AddressRepository : IAddressRepository
    {
        private readonly DataContext _context;

        public AddressRepository(DataContext _context)
        {
            this._context = _context;
        }

        public T_ADDRESS AddAdress(T_ADDRESS adress)
        {
            _context.T_Address.Add(adress);
            _context.SaveChanges();
            return adress;
        }

        public T_ADDRESS DeleteAdress(T_ADDRESS adress)
        {
            throw new NotImplementedException();
        }

        public T_ADDRESS GetAdressById(int Id)
        {
            return _context.T_Address.Where(p => p.Id == Id).FirstOrDefault();
        }

        public T_ADDRESS UpdateAdress(T_ADDRESS adress)
        {
            throw new NotImplementedException();
        }
    }
}
