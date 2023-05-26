using GigEconomyCore.Domain.Entity;

namespace GigEconomyCore.Domain.Model
{
    public class T_ACCIDENT
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int PartnerId { get; set; }
        public int Status { get; set; }

        public DateTime OccurredDate { get; set; }
        public bool RepliedNotification { get; set; }
        public string Description { get; set; }

    }
}
