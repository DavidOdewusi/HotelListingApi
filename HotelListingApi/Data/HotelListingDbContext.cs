using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                    new Country()
                    {
                        Id = 1,
                        Name = "Nigeria",
                        ShortName = "NGN",
                    },
                    new Country()
                    {
                        Id = 2,
                        Name = "United States Of America",
                        ShortName = "USA",
                    },
                    new Country()
                    {
                        Id = 3,
                        Name = "United Kingdom",
                        ShortName = "UK",
                    },
                    new Country()
                    {
                        Id = 4,
                        Name = "France",
                        ShortName = "FRA",
                    }
                );

            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel()
                    {
                        Id = 1,
                        Name = "Sheratton Hotel",
                        Rating = 4.2,
                        CountryId = 1,
                        Address = "Ikeja, Lagos"
                    },
                    new Hotel()
                    {
                        Id = 2,
                        Name = "Eko Hotel",
                        Rating = 4.5,
                        CountryId = 1,
                        Address = "Victoria Island, Lagos"
                    },
                    new Hotel()
                    {
                        Id = 3,
                        Name = "Burge Khalifa",
                        Rating = 4.1,
                        CountryId = 2,
                        Address = "Brooklyn, New York"
                    },
                    new Hotel()
                    {
                        Id = 4,
                        Name = "The Grand Hotel",
                        Rating = 5.0,
                        CountryId = 3,
                        Address = "Lincoln, London"
                    },
                    new Hotel()
                    {
                        Id = 5,
                        Name = "Rochester Champs Elysees",
                        Rating = 4.2,
                        CountryId = 4,
                        Address = "Paris"
                    }
                );
        }
    }
}
