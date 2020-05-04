using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Booking.DAL.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public Restaurant Restaurant { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
