using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Customer()
        {
            
        }
        public Customer(int id,string firstname,string lastname,string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;

        }
       
    }
}
