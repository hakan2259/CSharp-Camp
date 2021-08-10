using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            /*carManager.Add(new Car
            {
                BrandId = 14,
                ColorId = 2,
                ModelYear = 2020,
                DailyPrice = 1200,
                Description = "S90 2.0 B5 Inscription"
            });*/

            foreach (var car in carManager.GetCarsByBrandId(4))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("******************************");
            foreach (var car in carManager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.Description);
            }


            
            
        }
    }
}
