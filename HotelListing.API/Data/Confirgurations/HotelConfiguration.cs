using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Confirgurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Hotel Nikko Saigon",
                    Address = "235 Đ. Nguyễn Văn Cừ, Phường Nguyễn Cư Trinh, Quận 1, Thành phố Hồ Chí Minh",
                    CountryId = 1,
                    Rating = 4.6
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
