using HotelApi.Models;
using HotelApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("api/hotel")]
    [ApiController]
    public class HotelController : Controller
    {
        private readonly HotelService _hotelService;
        public HotelController(IHotelService hotelService) {
            _hotelService = (HotelService)hotelService;
        }
        [HttpPost("search")]
        public async Task<IActionResult> SearchHotels([FromBody] SearchRequest searchRequest)
        {
            var result = await _hotelService.SearchHotels(searchRequest);
            return Ok(result);
        }
        [HttpPost("availavility")]
        public async Task<IActionResult> CheckAvailability([FromBody] AvailabilityRequest availabilityRequest)
        {
            var result = await _hotelService.CheckAvailability(availabilityRequest);
            return Ok(result);
        }
        [HttpPost("prebook")]
        public async Task<IActionResult> PrebookHotel ([FromBody] PrebookRequest prebookRequest)
        {
            var result = await _hotelService.Prebook(prebookRequest);
            return Ok(result);
        }
        [HttpPost("book")]
        public async Task<IActionResult> BookHotel([FromBody] BookRequest bookRequest)
        {
            var result = await _hotelService.Book(bookRequest);
            return Ok(result);
        }
    }
}
