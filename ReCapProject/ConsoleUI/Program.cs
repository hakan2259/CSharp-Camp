using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Add(new Car
            {
                Id=6,BrandId=4,ColorId=5,ModelYear=2020,DailyPrice=375,Description= "Renault Megane 1.5 Blue DCI Touch"
            });
            Console.WriteLine("------List after car added-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Delete(new Car { Id = 2 });
            Console.WriteLine("------List after car deleted-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            carManager.Update(new Car { Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2013, DailyPrice = 5500, Description = "Chevrolet Corvette" });
            Console.WriteLine("------List after car updated-----");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("------Get by id-----");
            Car fetchCarById = carManager.GetById(1);
            Console.WriteLine(fetchCarById.Description);
            
        }
    }
}
