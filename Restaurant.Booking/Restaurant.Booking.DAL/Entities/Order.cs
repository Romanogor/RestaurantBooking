using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public int OrderStatusId { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int NumberOfPersons { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int OrderedById { get; set; }
        public Person OrderedBy { get; set; }
    }
}
