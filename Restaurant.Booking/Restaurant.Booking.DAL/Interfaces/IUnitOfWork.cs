using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Repositories
{
   public interface IUnitOfWork : IDisposable
    {
        IRestaurantRepository Restaurants { get; }
        IPersonRepository Persons { get; }
        IOrderRepository Orders { get; }

        int Complete();
    }
}
