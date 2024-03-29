﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarManagerTest();
            // ColorManagerTest();
            // BrandManagerTest();
            // UserManagerTest();
        }

        //private static void UserManagerTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    userManager.Add(new User
        //    { Id = 1, FirstName = "Mahmut", LastName = "Bebek", Email = "mahmut@gmail.com", PasswordHash = });
        //    userManager.Add(new User
        //    { Id = 2, FirstName = "Ahmet", LastName = "Araba", Email = "Ahmet@gmail.com", PasswordHash =  });
        //    var result = userManager.GetAll();
        //    if (result.Success == true)
        //    {
        //        foreach (var user in result.Data)
        //        {
        //            Console.WriteLine(user.FirstName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }


        //}

        private static void BrandManagerTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Id = 1, Name = "Audi" });
            brandManager.Add(new Brand { Id = 2, Name = "Kia" });


            var result = brandManager.GetAll();
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { Id = 1, Name = "Siyah" });
            colorManager.Add(new Color { Id = 2, Name = "Beyaz" });

            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.Name);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

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


            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName, " ", car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
