using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        public void AddPerson(Person person);
    }
}
