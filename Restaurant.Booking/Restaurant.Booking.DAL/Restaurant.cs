using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public City City { get; set; }
        public string Address { get; set; }
    }
}
