using MagicVilla_RestFullApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_RestFullApi.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) { }
        public DbSet<Villa> VillasDb { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Nice White Villa",
                    ImageUrl = "https://demo.sirv.com/nuphar.jpg?w=400",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft=550,
                    Amenity="",
                    CreateDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 2,
                    Name = "My Villa",
                    Details = "Cool Villa",
                    ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fres.cloudinary.com%2Fdemo%2Fimage%2Fupload%2Fv1312461204%2Fsample.jpg&tbnid=4WNHiXYnskNjjM&vet=12ahUKEwiM07PlmZaEAxXyp2MGHVCQC8MQMygAegQIARBY..i&imgrefurl=https%3A%2F%2Fcloudinary.com%2Fdocumentation%2Fadvanced_url_delivery_options&docid=vpbUSBPYu_DD9M&w=864&h=576&q=small%20size%20image%20url&ved=2ahUKEwiM07PlmZaEAxXyp2MGHVCQC8MQMygAegQIARBY",
                    Occupancy = 6,
                    Rate = 700,
                    Sqft = 540,
                    Amenity = "",
                    CreateDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 3,
                    Name = "White Villa",
                    Details = "Nice  Villa",
                    ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.m.wikipedia.org%2Fwiki%2FFile%3ATaj_Mahal_N-UP-A28-a.jpg&psig=AOvVaw06O3T4BLBamaWkxuVThvtZ&ust=1707291284097000&source=images&cd=vfe&opi=89978449&ved=0CBMQjRxqFwoTCOD7weWZloQDFQAAAAAdAAAAABAE",
                    Occupancy = 4,
                    Rate = 300,
                    Sqft = 450,
                    Amenity = "",
                    CreateDate = DateTime.Now

                }
                );
        }
    }
}
