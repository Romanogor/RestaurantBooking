using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Repositories
{
   public interface IUnitOfWork : IDisposable
    {
        IRestaurantRepository RestaurantRepository { get; }
        IPersonRepository PersonRepository { get; }
        IOrderRepository OrderRepository { get; }

        ITableRepository TableRepository { get; }

        Task<int> Complete();
    }
}
