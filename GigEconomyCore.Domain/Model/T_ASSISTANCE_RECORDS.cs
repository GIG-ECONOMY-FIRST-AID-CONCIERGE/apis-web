namespace GigEconomyCore.Domain.Model
{
    public class T_ASSISTANCE_RECORDS
    {
        public int Id { get; set; }
        public int AssistanceId { get; set; }
        public DateTime RecordDate { get; set; }
        public string Observation { get; set; }
    }
}
