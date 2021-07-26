using CoffeeShopCustomerManagement1.Abstract;
using CoffeeShopCustomerManagement1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCustomerManagement1.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(
                Convert.ToInt64(customer.NationalityId),
                customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),
                customer.DateOfBirth.Year
                );
        }
    }
}
