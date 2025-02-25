using HotelManagement.Entities;

namespace HotelManagement.Abstract
{
    public interface IHotelRepository
    {

        List<Hotel>GetAllHotels();
        Hotel GetHotelById(int id);

        Hotel createHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);
        Hotel DeleteHotel(int id);

    }
}
