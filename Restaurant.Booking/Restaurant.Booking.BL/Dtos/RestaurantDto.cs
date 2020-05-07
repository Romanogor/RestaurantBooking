using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.BL.Dtos
{
    public class RestaurantDto
    {
        public int RestaurantId { get; set; }

        public int CityId { get; set; }
        public string Address { get; set; }
    }
}
