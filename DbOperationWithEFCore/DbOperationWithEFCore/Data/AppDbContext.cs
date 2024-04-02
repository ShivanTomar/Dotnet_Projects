using DbOperationWithEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DbOperationWithEFCore.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() {Id=1,Title="INR", Description="Indian INR" },
                new Currency() {Id=2,Title="Dollar", Description="Collar" }  
                );
            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = 1, Title = "Hindi", Description = "Indian" },
                new Language() { Id = 2, Title = "English", Description = "Book" }
                );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<BookPrice> BookPrices { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}
