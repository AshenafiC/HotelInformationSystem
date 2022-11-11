using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelInformationSystem.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    id = 1,
                    Name = "Ethiopia",
                    ShortName = "ET"
                },
                new Country
                {
                    id = 2,
                    Name = "Kenya",
                    ShortName = "KN"
                },
                new Country
                {
                    id = 3,
                    Name = "Sudan",
                    ShortName = "SN"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    id = 1,
                    Name = "Ilily Hotel",
                    Address = "Addis Ababa",
                    CountryId = 1,
                    Rating = 4.8
                },
                new Hotel
                {
                    id = 2,
                    Name = "Sheraton Hotel",
                    Address = "Nairobi",
                    CountryId = 2,
                    Rating = 4.7
                },
                new Hotel
                {
                    id = 3,
                    Name = "Hilton",
                    Address = "Khartum",
                    CountryId = 3,
                    Rating = 4.9
                }
                );
        }
    }
}
