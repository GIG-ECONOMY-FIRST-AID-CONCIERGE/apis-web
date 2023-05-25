using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Helper;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Handler
{
    public class PartnerHandler
    {
        private readonly IPartnerRepository partnerRepository;
        private readonly IAddressRepository addressRepository;

        public PartnerHandler(IPartnerRepository _partnerRepository, IAddressRepository _addressRepository)
        {
            partnerRepository = _partnerRepository;
            addressRepository = _addressRepository;
        }
        public ICommandResult GetPartner(int Id)
        {
            if (Id < 1)
                return new GenericCommandResult(false, "Id informado é menor que o permitido", null);

            var partner = partnerRepository.GetPartnerById(Id);

            if (partner == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", partner);

        }

        public ICommandResult AddPartner(Partner partner)
        {
            if (partner == null)
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            PartnerMapper partnerMapper = new PartnerMapper();

            T_PARTNER t_partner = partnerMapper.Convert(partner);

            var addedPartner = partnerRepository.AddPartner(t_partner);

            var addedAddress = new T_ADDRESS();
            var addressMapper = new AddressMapper();
            T_ADDRESS t_address = addressMapper.Convert(partner.Address);

            if (partner.Address != null)
            {
                t_address.PartnerId = addedPartner.Id;
                addedAddress = addressRepository.AddAdress(t_address);                
            }
            partner = partnerMapper.Convert(addedPartner);

            if (addedAddress != null)
            {
                partner.Address = addressMapper.Convert(addressRepository.GetAdressByPartnerId(partner.Id));
            }
            return new GenericCommandResult(true, "Success", partner);
        }


    }
}
