using HotelManagement.Business.Abstract;
using HotelManagement.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        [HttpGet]
        public IActionResult Get()
        {

            var hotels = _hotelService.GetlAllHotels();
            return Ok(hotels);
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var hotel =  _hotelService.GetHotelById(id);

            if(hotel !=null)
            {

                return Ok(hotel);
            }

            return NotFound();
        }

        [HttpPost]

        public IActionResult Post([FromBody] Hotel hotel)
        {
           
            if(ModelState.IsValid)
            {
                var createHotel =  _hotelService.CreateHotel(hotel);
                return CreatedAtAction("Get", new {id = createHotel.Id}, createHotel);
            }

            return BadRequest(ModelState);
        }

        [HttpPut]

        public IActionResult Put([FromBody] Hotel hotel)
        {
            if(_hotelService.GetHotelById(hotel.Id) != null)
            {
                return Ok(_hotelService.UpdateHotel(hotel));
            }

            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            if (_hotelService.GetHotelById(id) != null)
            {
                _hotelService.DeleteHotel(id);
                return Ok(new { message = "Silme işlemi başarılı oldu." });

            }

            return NotFound(new { message = "Belirtilen otel bulunamadı." });
        }
    }
}
