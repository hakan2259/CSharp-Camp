using CoffeeShopCustomerManagement.Abstract;
using CoffeeShopCustomerManagement.Adapters;
using CoffeeShopCustomerManagement.Concrete;
using CoffeeShopCustomerManagement.Entities;
using System;

namespace CoffeeShopCustomerManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer { 
                DateOfBirth = new DateTime(1996, 3, 13), 
                FirstName = "Hakan", 
                LastName = "Sandal", 
                NationalityId = "15002004574"
                }
            );


        }
    }
}
