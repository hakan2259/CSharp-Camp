using CoffeeShopCustomerManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopCustomerManagement.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
