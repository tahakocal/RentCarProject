using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public void Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Araba kaydedildi");
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Arabanin ismi iki karakterden az olmamali ve arabanin fiyati sifirdan buyuk olmalidir.");
            }
        }


        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.Id + " Id'li araba bilgileri silindi!");
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine(car.Id + " Id'li araba bilgileri güncellendi!");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(c => c.ColorId == colorid);
        }

    }
}
