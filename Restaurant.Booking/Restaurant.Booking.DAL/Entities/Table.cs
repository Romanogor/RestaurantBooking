using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL.Entities
{
    public class Table
    {
        public int TableId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string Shape { get; set; }
        public int Capacity { get; set; }
    }
}
