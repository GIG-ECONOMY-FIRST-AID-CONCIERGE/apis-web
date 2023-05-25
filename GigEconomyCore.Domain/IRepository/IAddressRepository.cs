using GigEconomyCore.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.IRepository
{
    public interface IAddressRepository
    {
        T_ADDRESS GetAdressById(int Id);
        T_ADDRESS GetAdressByPartnerId(int Id);

        T_ADDRESS AddAdress(T_ADDRESS adress);

        T_ADDRESS UpdateAdress(T_ADDRESS adress);

        T_ADDRESS DeleteAdress(T_ADDRESS adress);
    }
}
