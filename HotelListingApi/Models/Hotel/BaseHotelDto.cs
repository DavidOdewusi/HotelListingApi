namespace HotelListingApi.Models.Hotel
{
    public abstract class BaseHotelDto
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Address { get; set; }
    }
}
