using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Country;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Configuations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, GetCountryDTO>().ReverseMap();
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CreateCountryDTO>().ReverseMap();
            CreateMap<Country, UpdateCountryDTO>().ReverseMap();

            CreateMap<Hotel, HotelDTO>().ReverseMap();
        }
    }
}
