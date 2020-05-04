using Restaurant.Booking.DAL.Entities;
using Restaurant.Booking.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL.Repositories
{
    public class TableRepository : Repository<Table>, ITableRepository
    {
        public TableRepository(ApplicationDbContext context) : base(context)
        {

        }


    }
}
