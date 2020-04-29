using Restaurant.Booking.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;            
        }
        public IRestaurantRepository Restaurants => new RestaurantRepository(_context);

        public IPersonRepository Persons => new PersonRepository(_context);

        public IOrderRepository Orders => new OrderRepository(_context);

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
