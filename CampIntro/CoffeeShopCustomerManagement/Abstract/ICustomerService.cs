using CoffeeShopCustomerManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopCustomerManagement.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);

    }
}
