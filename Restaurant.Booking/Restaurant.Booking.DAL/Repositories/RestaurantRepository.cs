using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;
using Restaurant.Booking.DAL.Entities;

namespace Restaurant.Booking.DAL.Repositories
{
    public class RestaurantRepository : Repository<Entities.Restaurant>, IRestaurantRepository
     {
        public RestaurantRepository(ApplicationDbContext context) : base(context)
        {

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
