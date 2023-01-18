
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
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
               new Country
               {
                   Id= 1,
                   Name = "Ho Chi Minh",
                   ShortName = "HCM"
               },
               new Country
               {
                   Id = 2,
                   Name = "Ha Noi",
                   ShortName = "HN"
               },
               new Country
               {
                   Id = 3,
                   Name = "Da Nang",
                   ShortName = "DN"
               }
            );
            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Hotel Nikko Saigon",
                   Address = "235 Đ. Nguyễn Văn Cừ, Phường Nguyễn Cư Trinh, Quận 1, Thành phố Hồ Chí Minh",
                   CountryId = 1,
                   Rating= 4.6
               },
               new Hotel
               {
                   Id = 2,
                   Name = "Hanoi Tirant Hotel",
                   Address = "38 P. Gia Ngư, Hàng Bạc, Hoàn Kiếm, Hà Nội",
                   CountryId = 2,
                   Rating = 4.7
               },
               new Hotel
               {
                   Id = 3,
                   Name = "Belle Maison Parosand Danang",
                   Address = "216 Võ Nguyên Giáp, Phước Mỹ, Sơn Trà, Đà Nẵng",
                   CountryId = 3,
                   Rating = 4.7
               }
            );
        }
    } 
}
