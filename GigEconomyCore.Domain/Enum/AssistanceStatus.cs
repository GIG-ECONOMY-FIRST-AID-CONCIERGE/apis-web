using System.ComponentModel;

namespace GigEconomyCore.Domain.Enum
{
    public enum AssistanceStatus
    {
        Comunicada = 1, //sinistro comunicado
        Andamento = 2, //verificou que é procedente (cadastro - veículo)
        Cancelada = 3, //parceiro cancelou / trote / não procedente
        Finalizada = 4 //assistencia prestada

    }

}