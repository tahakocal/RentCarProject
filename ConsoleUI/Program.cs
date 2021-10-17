using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagerTest();
            ColorManagerTest();
            BrandManagerTest();
        }

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 1, Name = "Audi" });
            brandManager.Add(new Brand { Id = 2, Name = "Kia" });
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 1, Name = "Siyah" });
            colorManager.Add(new Color { Id = 2, Name = "Beyaz" });
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 1,
                BrandId = 1,
                CarName = "Nissan",
                Description = "Nissan R34",
                ColorId = 5,
                ModelYear = 2001,
                DailyPrice = 500
            });
            carManager.Add(new Car
            {
                Id = 2,
                BrandId = 1,
                CarName = "BMW",
                Description = "BMW M4",
                ColorId = 1,
                ModelYear = 2020,
                DailyPrice = 0
            });
            carManager.Add(new Car
            {
                Id = 3,
                BrandId = 3,
                CarName = "Audi",
                Description = "A3",
                ColorId = 3,
                ModelYear = 2019,
                DailyPrice = 950
            });


            List<Car> cars = carManager.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine(car.CarName);
            }
        }
    }
}
