using BookTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracking
{
    public class BookTrackingDbContext : DbContext
    {
        public BookTrackingDbContext(DbContextOptions
    <BookTrackingDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<CategoryType> CategoryType { get; set; }
    }
}
