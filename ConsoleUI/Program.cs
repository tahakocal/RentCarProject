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
            carManager.Add(new Car { Id = 1, BrandId = 1, CarName = "R34", Description = "Nissan R34", ColorId = 5, ModelYear = 2001, DailyPrice = 500 });


            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(carManager);
            }




        }
    }
}
