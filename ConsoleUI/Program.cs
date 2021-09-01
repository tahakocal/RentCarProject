using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 1, CarName = "Nissan", Description = "Nissan R34", ColorId = 5, ModelYear = 2001, DailyPrice = 500 });
            carManager.Add(new Car { Id = 2, BrandId = 1, CarName = "BMW", Description = "BMW M4", ColorId = 1, ModelYear = 2020, DailyPrice = 0 });
            carManager.Add(new Car { Id = 3, BrandId = 3, CarName = "Scania", Description = "R420", ColorId = 3, ModelYear = 2019, DailyPrice = 950 });

            foreach (var VARIABLE in carManager.GetAll())
            {
                Console.WriteLine(carManager);
            }
        }
    }
}
