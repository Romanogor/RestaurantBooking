﻿using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;
using Restaurant.Booking.DAL.Entities;

namespace Restaurant.Booking.DAL.Interfaces
{
    public interface IRestaurantRepository : IRepository<Entities.Restaurant>
    {
        public IEnumerable<Table> GetFreeTables();
        public IEnumerable<Table> GetRestaurantFreeTables(int restaurantId);
    }
}
