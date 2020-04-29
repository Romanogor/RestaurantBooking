using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Interfaces
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        public void AddRestaurant(Restaurant restaurant);
        public void DeleteRestaurant(Restaurant restaurant);

        public IEnumerable<Table> GetFreeTables();
        public IEnumerable<Table> GetRestaurantFreeTables(int restaurantId);
    }
}
