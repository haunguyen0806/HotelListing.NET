using HotelListing.API.Models.Hotel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDTO : BaseCountryDTO
    {
        public int Id { get; set; }
    }
}
