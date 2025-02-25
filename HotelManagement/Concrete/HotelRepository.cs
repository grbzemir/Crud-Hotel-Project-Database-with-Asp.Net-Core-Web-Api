using HotelManagement.Abstract;
using HotelManagement.Entities;
using HotelManagement.DataAccess;

namespace HotelManagement.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            // Create a new instance of HotelDbContext
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Add(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }

        public Hotel DeleteHotel(int id)
        {
            // Delete a new instance of HotelDbContext
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

        public Hotel GetHotelByName(string name)
        {
           using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            //Update a new instance of HotelDbContext
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Update(hotel);
                hotelDbContext.SaveChanges();
                return hotel;
            }
        }
    }
}
