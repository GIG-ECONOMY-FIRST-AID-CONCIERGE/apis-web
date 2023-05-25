using GigEconomyCore.Domain.Entity;
using GigEconomyCore.Domain.Helper;
using GigEconomyCore.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigEconomyCore.Domain.Handler
{
    public class AssistanceHandler
    {
        private readonly IAssistanceRepository assistanceRepository;

        public AssistanceHandler(IAssistanceRepository _assistanceRepository)
        {
            assistanceRepository = _assistanceRepository;
        }
        public ICommandResult Handler(int Id)
        {
            if (Id < 1)
                return new GenericCommandResult(false, "Id informado é menor que o permitido", null);

            var assistance = assistanceRepository.GetAssistanceById(Id);

            if (assistance == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            return new GenericCommandResult(true, "Success", assistance);

        }

        public ICommandResult Handler(string status)
        {
            if (String.IsNullOrEmpty(status))
                return new GenericCommandResult(false, "O Parâmetro não pode ser nulo", null);

            //var assistance = assistanceRepository.GetAssistanceByStatus(status);

            //if (assistance == null)
                return new GenericCommandResult(false, "Não foram encontrados registros correspondentes ao Id Informado", null);

            //return new GenericCommandResult(true, "Success", assistance);

        }

        
    }
}
