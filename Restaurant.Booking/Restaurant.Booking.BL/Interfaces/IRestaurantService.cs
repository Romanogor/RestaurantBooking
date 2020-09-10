using Restaurant.Booking.BL.Dtos;
using Restaurant.Booking.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Booking.BL.Interfaces
{
    public interface IRestaurantService
    {
        public RestaurantDto AddRestaurant(RestaurantDto restaurant);

        public Task<IEnumerable<RestaurantDto>> GetRestaurants();
        public Task<RestaurantDto> GetRestaurant(int id);
        public Task RemoveRestaurant(RestaurantDto restaurantDto);
        public Task<TableDto> AddTable(TableDto tableDto);
        public Task AddTables(List<TableDto> tableDtos);
        
    }
}
