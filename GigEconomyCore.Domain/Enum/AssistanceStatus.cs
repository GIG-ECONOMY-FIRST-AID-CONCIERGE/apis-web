namespace GigEconomyCore.Domain.Enum
{
    public enum AssistanceStatus
    {
        Comunicada, //sinistro comunicado
        Andamento, //verificou que é procedente (cadastro - veículo)
        Cancelada, //parceiro cancelou / trote / não procedente
        Finalizada //assistencia prestada
    }
}