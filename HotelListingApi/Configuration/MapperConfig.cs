using AutoMapper;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;
using HotelListingApi.Models.Hotel;

namespace HotelListingApi.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetCountryDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();
            CreateMap<Hotel, GetHotelDto>().ReverseMap();  
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();  
            CreateMap<Hotel, HotelDto>().ReverseMap();  
        }
    }
}
