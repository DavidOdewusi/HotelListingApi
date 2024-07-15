using HotelListingApi.Data;

namespace HotelListingApi.Contracts
{
    public interface IHotelRepository : IGenericRepository<Hotel>
    {
        Task<Hotel> GetDetails(int?  id);
    }
}
