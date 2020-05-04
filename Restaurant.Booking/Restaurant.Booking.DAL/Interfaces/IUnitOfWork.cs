using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Repositories
{
   public interface IUnitOfWork : IDisposable
    {
        IRestaurantRepository RestaurantRepository { get; }
        IPersonRepository PersonRepository { get; }
        IOrderRepository OrderRepository { get; }

        ITableRepository TableRepository { get; }

        int Complete();
    }
}
