using CoffeeShopCustomerManagement1.Abstract;
using CoffeeShopCustomerManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomerManagement1.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
