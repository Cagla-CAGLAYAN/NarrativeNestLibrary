namespace NarrativeNest.Models.Entities
{
    public class Donation
    {
        public Guid DonationId { get; set; }  // Primary Key
        public required DateTime DonationDate { get; set; }

        // Foreign Keys
        public Guid UserId { get; set; }  // Foreign Key to Users
        public Guid BookId { get; set; }  // Foreign Key to Books

        // Navigation Properties
        public User User { get; set; }   // Navigation Property to User
        public Books Book { get; set; }   // Navigation Property to Book
    }
}
