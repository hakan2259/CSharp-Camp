using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Hakan";
            customer1.LastName = "Sandal";
            customer1.NationalityId = "2153230";
            customer1.Email = "hakan.sandal9@hotmail.com";
            customer1.Address = "Atatürk mahallesi kapaklı";
            customer1.City = "Tekirdağ";


            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Betül";
            customer2.LastName = "Yeşildağ";
            customer2.NationalityId = "1212312";
            customer2.Email = "betul.yesildag9@hotmail.com";
            customer2.Address = "yavuz sultan selim mahallesi cerkezkoy";
            customer2.City = "Tekirdağ";

            Customer[] customers = new Customer[]{
                customer1,
                customer2,
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.CustomerListing(customers);
            customerManager.Delete(customer1);
        }
    }
}
