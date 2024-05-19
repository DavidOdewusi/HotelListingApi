namespace HotelListingApi.Models.Hotel
{
    public class HotelDto : BaseHotelDto
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
    }
}
