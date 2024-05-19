using HotelListingApi.Contracts;
using HotelListingApi.Data;

namespace HotelListingApi.Repository
{
    public class CountryRepository : GenericRepository<Country>, ICountriesRepository
    {
        public CountryRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}
