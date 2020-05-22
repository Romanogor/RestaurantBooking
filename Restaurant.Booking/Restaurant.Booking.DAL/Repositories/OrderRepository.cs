using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;
using Restaurant.Booking.DAL.Entities;

namespace Restaurant.Booking.DAL.Repositories
{
   public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async void ChangeOrderStatus(Order order, OrderStatus orderStatus)
        {
            var orderInDb = await Get(order.OrderId);
            orderInDb.OrderStatus = orderStatus;            
        }
    }
}
