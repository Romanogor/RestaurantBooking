using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
     {
        public RestaurantRepository(ApplicationDbContext context) : base(context)
        {

        }

        public void AddRestaurant(Restaurant restaurant)
        {
            Add(restaurant);
        }

        public void DeleteRestaurant(Restaurant restaurant)
        {
            Remove(restaurant);
        }

        public IEnumerable<Table> GetFreeTables()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Table> GetRestaurantFreeTables(int restaurantId)
        {
            throw new NotImplementedException();
        }
    }
}
