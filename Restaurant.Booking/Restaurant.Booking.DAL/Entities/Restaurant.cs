﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL.Entities
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
        public string Address { get; set; }

        public IEnumerable<Table> Tables { get; set; }
    }
}
