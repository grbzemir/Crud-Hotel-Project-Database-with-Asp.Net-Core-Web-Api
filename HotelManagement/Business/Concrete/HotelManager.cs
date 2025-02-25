using HotelManagement.Abstract;
using HotelManagement.Business.Abstract;
using HotelManagement.Entities;

namespace HotelManagement.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        //Dependy Injection
        private readonly IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public Hotel CreateHotel(Hotel hotel)
        {
            return _hotelRepository.createHotel(hotel);
        }

        public Hotel DeleteHotel(int id)
        {
           return _hotelRepository.DeleteHotel(id);
        }

        public Hotel GetHotelById(int id)
        {
            return _hotelRepository.GetHotelById(id);
        }

        public List<Hotel> GetlAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel);
        }
    }
}
