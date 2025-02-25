using HotelManagement.Abstract;
using HotelManagement.Entities;
using HotelManagement.DataAccess;

namespace HotelManagement.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel createHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Hotel DeleteHotel(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deletedHotel = hotelDbContext.Hotels.Find(id);
                hotelDbContext.Hotels.Remove(deletedHotel);
                hotelDbContext.SaveChanges();
                return deletedHotel;
            }
        }

        public List<Hotel> GetAllHotels()
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.ToList();
            }
        }

        public Hotel GetHotelById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.Find(id);
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
