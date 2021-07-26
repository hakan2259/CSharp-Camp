using CoffeeShopCustomerManagement.Abstract;
using CoffeeShopCustomerManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopCustomerManagement.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();

        }
    }
}
