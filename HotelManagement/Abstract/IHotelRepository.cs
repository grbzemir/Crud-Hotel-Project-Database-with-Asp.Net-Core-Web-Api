using HotelManagement.Entities;

namespace HotelManagement.Abstract
{
    public interface IHotelRepository
    {

        List<Hotel>GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel GetHotelByName(string name);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        Hotel DeleteHotel(int id);

    }
}
