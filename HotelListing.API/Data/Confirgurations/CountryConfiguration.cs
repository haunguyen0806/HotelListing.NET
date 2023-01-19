using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Confirgurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
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
        }
    }
}
