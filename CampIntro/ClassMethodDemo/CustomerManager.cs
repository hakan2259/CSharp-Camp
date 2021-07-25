using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added " + customer.FirstName + " " + customer.LastName);
        }
        public void CustomerListing(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted " + customer.FirstName + " " + customer.LastName);
        }
    }
}
