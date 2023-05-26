using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Helper;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Domain.Utils;
using Microsoft.EntityFrameworkCore;
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

            var t_partner = partnerRepository.GetPartnerById(Id);

            if (t_partner == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            var partnerMapper = new PartnerMapper();
            var addressMapper = new AddressMapper();

            var partner = partnerMapper.Convert(t_partner);

            var t_address = addressRepository.GetAdressByPartnerId(Id);
            if (t_address != null)
            { partner.Address = addressMapper.Convert(t_address);
            partner.Address.PartnerId = partner.Id;}


            return new GenericCommandResult(true, "Success", partner);

        }

        public ICommandResult AddPartner(Partner partner)
        {
            if (partner == null)
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            var addedPartner = new Partner();
            PartnerMapper partnerMapper = new PartnerMapper();

            T_PARTNER t_partner = partnerMapper.Convert(partner);

            var previousPartner = partnerRepository.GetPartnerByNationalId(partner.Cpf);
            
            if (previousPartner != null)
            {
                t_partner.Id = previousPartner.Id;
                partnerRepository.UpdatePartner(t_partner);

            }
            else
                partnerRepository.AddPartner(t_partner);
                
            var addedAddress = new T_ADDRESS();
            var addressMapper = new AddressMapper();
            T_ADDRESS t_address = addressMapper.Convert(partner.Address);

            if (partner.Address != null)
            {
                t_address.PartnerId = partner.Id;
                addedAddress = addressRepository.AddAdress(t_address);                
            }

            partner = partnerMapper.Convert(t_partner);

            if (addedAddress != null)
            {
                partner.Address = addressMapper.Convert(addressRepository.GetAdressByPartnerId(partner.Id));
            }
            return new GenericCommandResult(true, "Success", partner);
        }


    }
}
