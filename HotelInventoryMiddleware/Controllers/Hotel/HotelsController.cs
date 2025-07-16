using HotelInventoryMiddleware.Models;
using HotelInventoryMiddleware.Services;
using Microsoft.AspNetCore.Mvc;

namespace HotelInventoryMiddleware.Controllers.Hotel
{
    [ApiController]
    [Route("api/hotels")]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpPost("search")]
        public async Task<ActionResult<SearchResponse>> Search([FromBody] SearchRequest request, CancellationToken cancellationToken)
        {
            var response = await _hotelService.SearchHotelsAsync(request, cancellationToken);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
