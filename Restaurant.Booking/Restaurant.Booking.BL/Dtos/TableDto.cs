using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.BL.Dtos
{
    public class TableDto
    {
        public int TableId { get; set; }

        public int RestaurantId { get; set; }
        
        public string Shape { get; set; }
        public int Capacity { get; set; }

    }
}
