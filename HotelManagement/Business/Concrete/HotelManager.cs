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
            return _hotelRepository.CreateHotel(hotel);
        }

        public Hotel DeleteHotel(int id)
        {
           return _hotelRepository.DeleteHotel(id);

        }

        public Hotel GetHotelById(int id)
        {
            if(id>0)
            {
                return _hotelRepository.GetHotelById(id);
            }

            throw new System.Exception("Id cannot be less than 1");
            
        }

        public Hotel GetHotelByName(string name)
        {
            
            return _hotelRepository.GetHotelByName(name);
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
