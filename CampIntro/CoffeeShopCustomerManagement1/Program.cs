using CoffeeShopCustomerManagement1.Abstract;
using CoffeeShopCustomerManagement1.Adapters;
using CoffeeShopCustomerManagement1.Concrete;
using CoffeeShopCustomerManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomerManagement1
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(1996, 3, 13),
                FirstName = "Hakan",
                LastName = "Sandal",
                NationalityId = "15002004574"
            });

            Console.ReadLine();
        }
    }
}
