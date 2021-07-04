using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Id = 1, BrandId = 1, CarName = "Nissan", Description = "Nissan R34", ColorId = 5, ModelYear = 2001, DailyPrice = 500 });
            carManager.Add(new Car { Id = 2, BrandId = 1, CarName = "BMW", Description = "BMW M4", ColorId = 1, ModelYear = 2020, DailyPrice = 0 });


            foreach (var VARIABLE in carManager.GetAll())
            {
                Console.WriteLine(carManager);
            }

        }
    }
}
