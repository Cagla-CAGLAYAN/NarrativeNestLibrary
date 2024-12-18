namespace NarrativeNest.Models.Entities
{
    public class Books
    {
        public Guid BookId { get; set; }  // Primary Key
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }

        public String BookStatus { get; set; }
        public required int PageNumber { get; set; }
        public int? PublishedYear { get; set; }
        public string? Publisher { get; set; }
        public string? PublicationPlace { get; set; }

        // Navigation Property
        public List<Favorite> Favorites { get; set; }  // One-to-Many (Book to Favorite)
        public List<Borrow> Borrows { get; set; }      // One-to-Many (Book to Borrow)
        public List<Donation> Donations { get; set; }  // One-to-Many (Book to Donation)
    }
}
