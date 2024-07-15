using HotelListingApi.Contracts;
using HotelListingApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingApi.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelRepository
    {
        private readonly HotelListingDbContext _context;

        public HotelRepository(HotelListingDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Hotel> GetDetails(int? id)
        {
            return await _context.Hotels.Include(q => q.Country)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
