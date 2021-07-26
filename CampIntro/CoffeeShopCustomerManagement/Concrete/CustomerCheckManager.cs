using CoffeeShopCustomerManagement.Abstract;
using CoffeeShopCustomerManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopCustomerManagement.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
