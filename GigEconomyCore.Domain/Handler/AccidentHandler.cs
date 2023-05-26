using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Enum;
using GigEconomyCore.Domain.Helper;
using GigEconomyCore.Domain.IRepository;
using GigEconomyCore.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Handler
{
    public class AccidentHandler
    {
        private readonly IAccidentRepository accidentRepository;
        private readonly IAssistanceRepository assistanceRepository;
        private readonly IPartnerRepository partnerRepository;
        private readonly IAddressRepository addressRepository;
        private readonly IVehicleRepository vehicleRepository;



        public AccidentHandler(IAccidentRepository _accidentRepository, 
            IAssistanceRepository _assistanceRepository,
            IPartnerRepository _partnerRepository,
            IAddressRepository _addressRepository,
            IVehicleRepository _vehicleRepository)
        {
            accidentRepository = _accidentRepository;
            assistanceRepository = _assistanceRepository;
            partnerRepository = _partnerRepository;
            addressRepository = _addressRepository;
            vehicleRepository = _vehicleRepository;
        }
        public ICommandResult Handler(int id)
        {
            if (id < 1)
                return new GenericCommandResult(false, "Id informado é menor que o permitido", null);

            var accident = GetAccidente(id);

            if (accident == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", accident);

        }

        public ICommandResult HandlerAdd(Accident _accident)
        {
            if (_accident == null)
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            var accident = AddAccidente(_accident);
           
            if (accident == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", accident);

        }

        public ICommandResult HandlerStatus(int status)
        {
            if (status == null)
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            var accident = GetAccidentes(status);

            if (accident == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", accident);

        }
        private List<AccidentResponse> GetAccidentes(int status)
        {
            List<AccidentResponse> accidents = new List<AccidentResponse>();

            var accident = accidentRepository.GetAccidentByStatus(status);
            if (accident == null)
                return null;

            foreach (T_ACCIDENT a in accident)
            {
                accidents.Add(GetAccidente(a.Id));
            }

            return accidents;
        }
        private AccidentResponse GetAccidente(int id)
        {
            List<AccidentResponse> accidents = new List<AccidentResponse>();

            var accident = accidentRepository.GetAccidentById(id);
            if (accident == null)
                return null;

            AccidentResponse ac = new AccidentResponse();
            ac.Id = accident.Id;
            ac.Address = parseAddress(addressRepository.GetAdressById(accident.AddressId));
            ac.Partner = parsePartner(partnerRepository.GetPartnerById(accident.PartnerId));
            ac.Assistances = parseAssistances(accident);
            ac.Status = ac.Status;
            ac.OccurredDate = accident.OccurredDate;
            ac.RepliedNotification = accident.RepliedNotification;
            accidents.Add(ac);
            
            return ac;
        }
        private AccidentResponse AddAccidente(Accident _accident)
        {

            T_ACCIDENT tAccident = new T_ACCIDENT();
          
            T_ADDRESS tAddress = new T_ADDRESS();

            var tPartner = partnerRepository.GetPartnerById(_accident.PartnerId);
            if (tPartner == null)
                return null;

            tAddress.PartnerId = tPartner.Id;
            tAddress.Street = _accident.Address.Street;
            tAddress.Number = _accident.Address.Number;
            tAddress.PostalCode = _accident.Address.PostalCode;
            tAddress.City = _accident.Address.City;
            tAddress.State = _accident.Address.State;
            tAddress.CoordX = _accident.Address.CoordX;
            tAddress.CoordY = _accident.Address.CoordY;

            tAddress = addressRepository.AddAdress(tAddress);
            if (tAddress == null)
                return null;

            tAccident.PartnerId = tPartner.Id;
            tAccident.AddressId = tAddress.Id;
            tAccident.OccurredDate = DateTime.Now;
            tAccident.RepliedNotification = _accident.RepliedNotification;
            tAccident.Status = 1;

            tAccident = accidentRepository.AddAccident(tAccident);
            if (tAccident == null)
                return null;

            foreach (var assistence in _accident.Assistances)
            {
                T_ASSISTANCE tAssistence = new T_ASSISTANCE();
                tAssistence.PartnerId = tPartner.Id;
                tAssistence.Name = assistence.Name;
                tAssistence.Description = assistence.Description;
                tAssistence.Type = (int)assistence.Type;
                tAssistence.SinisterCircumstances = assistence.SinisterCircumstances;
                tAssistence.Status = (int)assistence.Status;
                tAssistence.AccidentId = tAccident.Id;

                tAssistence = assistanceRepository.AddAssistance(tAssistence);
                if (tAssistence == null)
                    return null;

                assistence.Id = tAssistence.Id;

            }

            return parseAccidente(tAccident, tPartner, tAddress);
        }

        private AccidentResponse parseAccidente(T_ACCIDENT tAccident, T_PARTNER tPartner, T_ADDRESS tAddress)
        {
            AccidentResponse accidentResponse = new AccidentResponse();
            accidentResponse.Id = tAccident.Id;
            accidentResponse.Partner = parsePartner(tPartner);
            accidentResponse.Address = parseAddress(tAddress);
            accidentResponse.Assistances = parseAssistances(tAccident);
            accidentResponse.Status = (AccidentStatus)tAccident.Status;

            return accidentResponse;
        }

        private List<Assistance> parseAssistances(T_ACCIDENT tAccident)
        {
            List<Assistance> assistences = new List<Assistance>();

            List<T_ASSISTANCE> tAssistences = assistanceRepository.GetAssistanceByAccidentId(tAccident.Id);

            foreach (T_ASSISTANCE ta in tAssistences)
            {
                Assistance a = new Assistance();
                a.Id = ta.Id;
                a.Name = ta.Name;
                a.Description = ta.Description;
                a.SinisterCircumstances = ta.SinisterCircumstances;
                a.Status = (AssistanceStatus)1;
                a.Type = (AssistanceType)1;

                assistences.Add(a);
            }
            return assistences;
        }

        private Partner parsePartner(T_PARTNER tPartner)
        {
            Partner partner = new Partner();
            T_ADDRESS partnerAddress = addressRepository.GetAdressByPartnerId(tPartner.Id);
            partner.Id = tPartner.Id;
            partner.Address = parseAddress(partnerAddress);
            partner.Cpf = tPartner.Cpf;
            partner.Rg = tPartner.Rg;
            partner.Name = tPartner.Name;
            partner.BirthDate = tPartner.BirthDate;
            //partner.Phone = tPartner.Phone;

            return partner;
        }
        private static Address parseAddress(T_ADDRESS tAddress)
        {
            Address address = new Address();
            address.Id = tAddress.Id;
            address.Street = tAddress.Street;
            address.Number = tAddress.Number;
            address.PostalCode = tAddress.PostalCode;
            address.City = tAddress.City;
            address.State = tAddress.State;
            address.CoordX = tAddress.CoordX;
            address.CoordY = tAddress.CoordY;

            return address;
        }



    }
}
