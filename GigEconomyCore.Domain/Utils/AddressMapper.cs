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

        public T_ADDRESS Convert(Address address)
        {
            T_ADDRESS t_address = new T_ADDRESS();

            t_address.Id = address.Id;
            t_address.Street = address.Street;
            t_address.Number = address.Number;
            t_address.PostalCode = address.PostalCode;
            t_address.State = address.State;
            t_address.City = address.City;
            t_address.CoordX = address.CoordX;
            t_address.CoordY = address.CoordY;

            return t_address;
        }

        public Address Convert(T_ADDRESS t_address)
        {
            Address address = new Address();

            address.Id = t_address.Id;
            address.Street = t_address.Street;
            address.Number = t_address.Number;
            address.State = t_address.State;
            address.City = t_address.City;
            address.PostalCode = t_address.PostalCode;
            address.CoordX = t_address.CoordX;
            address.CoordY = t_address.CoordY;

            return address;
        }
    }
}
