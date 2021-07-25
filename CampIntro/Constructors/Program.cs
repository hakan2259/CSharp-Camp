using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Hakan", LastName = "Sandal", City = "Tekirdağ" };


            Customer customer2 = new Customer(2, "Betul", "Yesildag", "Tekirdağ");
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
        }
    }
}
