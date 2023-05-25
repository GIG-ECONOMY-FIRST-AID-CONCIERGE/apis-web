using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Helper;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using GigEconomyCore.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Handler
{
    public class PartnerHandler
    {
        private readonly IPartnerRepository partnerRepository;
        
        public PartnerHandler(IPartnerRepository _partnerRepository)
        {
            partnerRepository = _partnerRepository;
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

        public ICommandResult GetPartner(string NationalId)
        {
            if (String.IsNullOrEmpty(NationalId))
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            var partner = partnerRepository.GetPartnerByNationalId(NationalId);

            if (partner == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", partner);
        }

        public ICommandResult AddPartner(Partner partner)
        {
            if (partner == null)
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            PartnerMapper partnerMapper = new PartnerMapper(partner);

            T_PARTNER t_partner = partnerMapper.Convert();

            var addedPartner = partnerRepository.AddPartner(t_partner);

            return new GenericCommandResult(true, "Success", partner);
        }


    }
}
