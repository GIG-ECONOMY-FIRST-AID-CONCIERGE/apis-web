using GigEconomyCore.Domain.Enum;

namespace GigEconomyCore.Domain.Entity
{
    public class AssistanceRecords
    {
        public int Id { get; set; }
        public int AssistanceId { get; set; }
        public DateTime RecordDate { get; set; }
        public string Observation { get; set; }
        
    }
}