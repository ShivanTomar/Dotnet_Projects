using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DatabaseContext
{
    public class ApplicationDbContext : DbContext {

        public ApplicationDbContext(DbContextOptions options) : base(options) {

        }

        public ApplicationDbContext() { }

        public virtual DbSet<City> Cities { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = Guid.Parse("A052DCAD-2A59-49E3-8177-454D976CFDF3"),
                CityName="Indore"
            }) ;
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId= Guid.Parse( "32775A13-A3A9-4B5B-A0EA-50B1FFEB2980"),
                CityName = "Bhopal"
            });
        }

    }
}
