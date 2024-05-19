using HotelListingApi.Models.Hotel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingApi.Models.Country
{
    public class GetCountryDto : BaseCountryDto
    {
        public int Id { get; set; }
    }

}
