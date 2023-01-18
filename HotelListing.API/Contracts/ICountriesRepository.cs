using HotelListing.API.Data;
using System.Threading.Tasks;

namespace HotelListing.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
