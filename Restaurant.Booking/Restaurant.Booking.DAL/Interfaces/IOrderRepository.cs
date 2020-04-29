using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        public void AddOrder(Order order);
        public void ChangeOrderStatus(Order order, OrderStatus orderStatus);
    }
}
