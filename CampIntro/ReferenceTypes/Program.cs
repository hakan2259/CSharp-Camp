using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean value types
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 100;
            Console.WriteLine("Number1 = " + number1);

            //arrays,class,interface... reference types
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[] { 10, 20, 30 };

            numbers1 = numbers2;
            numbers2[0] = 1000;
            Console.WriteLine("Numbers1[0] = "+ numbers1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Hakan";
            person2 = person1;
            person1.FirstName = "Betul";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Yigit";
            customer.CreditCardNumber = "1234567890";
            Employee employee = new Employee();
            employee.FirstName = "Melih";


            Person person3 = customer;
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
