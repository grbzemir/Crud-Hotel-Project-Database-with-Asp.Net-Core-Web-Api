using HotelManagement.Entities;

namespace HotelManagement.Business.Abstract
{
    public interface IHotelService
    {

        List<Hotel> GetlAllHotels();
        Hotel GetHotelById(int id);
        Hotel GetHotelByName(string name);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        Hotel DeleteHotel(int id);


    }
}
