using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Utils
{
    public class AddressMapper
    {
        private readonly Address address;

        public AddressMapper(Address address)
        {
            this.address = address;
        }

        public T_ADDRESS Convert()
        {
            T_ADDRESS t_address = new T_ADDRESS();

            t_address.Id = address.Id;
            t_address.PartnerId = address.PartnerId;
            t_address.Street = address.Street;
            t_address.Number = address.Number;
            t_address.State = address.State;
            t_address.City = address.City;
            t_address.CoordX = address.CoordX;
            t_address.CoordY = address.CoordY;

            return t_address;
        }
    }
}
