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
        private readonly ISinisterRepository sinisterRepository;
        private readonly IAddressRepository addressRepository;
        private readonly IVehicloRepository vehicloRepository;

       

        public AccidentHandler(IAccidentRepository _accidentRepository)
        {
            accidentRepository = _accidentRepository;
    }
        public ICommandResult Handler(int Id)
        {
            if (Id < 1)
                return new GenericCommandResult(false, "Id informado é menor que o permitido", null);

            var accident = accidentRepository.GetAccidentById(Id);

            if (accident == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", accident);

        }

        public ICommandResult HandlerAdd(Accident _accident)
        {
            if (_accident == null)
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            var accident = new Accident();
            /*var accident = accidentRepository.AddAccident(_accident);
            var sinister = sinisterRepository.AddAccident(_accident);
            var address = AddressRepository.AddAccident(_accident);
            var vehiclo = vehicleRepository.AddAccident(_accident);*/


            if (accident == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", accident);

        }

        public ICommandResult Handler(string status)
        {
            if (String.IsNullOrEmpty(status))
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            var accident = accidentRepository.GetAccidentByStatus(status);

            if (accident == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", accident);

        }

        
    }
}
