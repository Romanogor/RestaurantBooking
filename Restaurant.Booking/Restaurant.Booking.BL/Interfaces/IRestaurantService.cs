using Restaurant.Booking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Booking.BL.Interfaces
{
    public interface IRestaurantService
    {
        public DAL.Entities.Restaurant AddRestaurant(DAL.Entities.Restaurant restaurant);

        public Task<IEnumerable<DAL.Entities.Restaurant>> GetRestaurants();
        public Task<DAL.Entities.Restaurant> GetRestaurant(int id);
        public Task RemoveRestaurant(DAL.Entities.Restaurant restaurant);
        public Task<Table> AddTable(Table table);
        public Task AddTables(List<Table> tables);
        
    }
}
