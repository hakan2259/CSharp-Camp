using CoffeeShopCustomerManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopCustomerManagement.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db!" + customer.FirstName);
        }
    }
}
