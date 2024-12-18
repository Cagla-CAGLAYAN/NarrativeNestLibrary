using System.ComponentModel.DataAnnotations;

namespace NarrativeNest.Models.Entities
{
    public class User
    {
        public Guid UserId { get; set; }  // Primary Key
        public required string UserName { get; set; }
        public required string UserSurname { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public required string Role { get; set; }


        // Navigation Properties
        public List<Favorite> Favorites { get; set; }  // One-to-Many (User to Favorite)
        public List<Borrow> Borrows { get; set; }      // One-to-Many (User to Borrow)
        public List<Donation> Donations { get; set; }  // One-to-Many (User to Donation)
        public List<Reservation> Reservations { get; set; } // One-to-Many (User to Reservation)
    }
}

