using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelListingApi.Data;
using HotelListingApi.Models.Country;
using AutoMapper;
using HotelListingApi.Repository;
using HotelListingApi.Contracts;

namespace HotelListingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICountriesRepository _context;

        public CountriesController(IMapper mapper, ICountriesRepository countryRepository)
        {
            _mapper = mapper;
            this._context = countryRepository;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCountryDto>>> GetCountries()
        {
            var countries = await _context.GetAllAsync();
            var getCountryDtos = _mapper.Map<List<GetCountryDto>>(countries);

            return Ok(getCountryDtos);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            var country = await _context.GetDetails(id);


            if (country == null)
            {
                return NotFound();
            }
            
            var countryDto = _mapper.Map<CountryDto>(country);

            return countryDto;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, UpdateCountryDto updateCountryDto)
        {
            if (id != updateCountryDto.Id)
            {
                return BadRequest("Invalid Record Id");
            }

            //_context.Entry(country).State = EntityState.Modified;

            var country = _context.GetAsync(id);

            await _mapper.Map(updateCountryDto, country);

            try
            {
                await _context.UpdateAsync(country.Result);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CountryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Countries
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Country>> PostCountry(CreateCountryDto createCountry)
        {
            var country = _mapper.Map<Country>(createCountry);
            await _context.AddAsync(country);

            return CreatedAtAction("GetCountry", new { id = country.Id }, country);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _context.GetAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            await _context.DeleteAsync(id);

            return NoContent();
        }

        private bool CountryExists(int id)
        {
            return _context.Exists(id).Result;
        }
    }
}
