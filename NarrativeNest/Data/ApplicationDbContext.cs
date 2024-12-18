using Microsoft.EntityFrameworkCore;
using NarrativeNest.Models.Entities;

namespace NarrativeNest.Data
{
    public class ApplicationDbContext: DbContext
    {
         
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }

            public DbSet<Books> Books { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Books>()
            .   HasKey(b => b.BookId);
            }
        public DbSet<Borrow> Borrows { get; set; }
            public DbSet<Desk> Desks { get; set; }
            public DbSet<Donation> Donations { get; set; }
            public DbSet<Favorite> Favorites { get; set; }
            public DbSet<Reservation> Reservations { get; set; }
            public DbSet<User> Users { get; set; }
        }
        
}

