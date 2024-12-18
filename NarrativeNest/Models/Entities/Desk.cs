namespace NarrativeNest.Models.Entities
{
    public class Desk
    {
        public Guid DeskId { get; set; }  // Primary Key
        public required int DeskNumber { get; set; }
        public enum DStatus
        {
            Reserved,
            Available
        }
        public DStatus DeskStatus { get; set; }

        // Navigation Property
        public List<Reservation> Reservations { get; set; }
    }
}

