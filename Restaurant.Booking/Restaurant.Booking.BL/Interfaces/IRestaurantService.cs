using Restaurant.Booking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.BL.Interfaces
{
    public interface IRestaurantService
    {
        public DAL.Entities.Restaurant AddRestaurant(DAL.Entities.Restaurant restaurant);

        public IEnumerable<DAL.Entities.Restaurant> GetRestaurants();
        public DAL.Entities.Restaurant GetRestaurant(int id);
        public void RemoveRestaurant(DAL.Entities.Restaurant restaurant);
        public Table AddTable(Table table);
        public void AddTables(List<Table> tables);
        
    }
}
