using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;
using Restaurant.Booking.DAL.Entities;

namespace Restaurant.Booking.DAL.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        public void ChangeOrderStatus(Order order, OrderStatus orderStatus);
    }
}
