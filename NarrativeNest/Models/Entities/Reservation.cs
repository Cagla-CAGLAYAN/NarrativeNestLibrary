namespace NarrativeNest.Models.Entities
{
    public class Reservation
    {
        public Guid ReservationId { get; set; }  // Primary Key
        public required DateTime ReservationDate { get; set; }
        public required DateTime TimeSlot { get; set; }

        public String ReservationStatus { get; set; }


        // Foreign Keys
        public Guid UserId { get; set; }
        public Guid DeskId { get; set; }

        // Navigation Properties
        public User User { get; set; }
        public Desk Desk { get; set; }
    }
}

