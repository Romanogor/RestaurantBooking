using System;
using System.Collections.Generic;
using System.Text;
using Restaurant.Booking.DAL.Interfaces;

namespace Restaurant.Booking.DAL.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void AddPerson(Person person)
        {
            Context.Persons.Add(person);
        }
    }
}
