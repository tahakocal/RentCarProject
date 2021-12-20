using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Business.Constants;
using Core.Utilities.Result;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }


        public Result Add(Car car)
        {
            if (car.CarName.Length > 2 && car.DailyPrice > 0)
            {
                return new ErrorResult(Messages.LenghtNotEnough);
                
            }
            _carDal.Add(car);
            return new Result(true, Messages.CarAdded);
        }


        public Result Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine(car.Id + " Id'li araba bilgileri silindi!");
        }

        public Result Update(Car car)
        {
            return new ErrorResult(car.Id, " ", Messages.CarNotUpdated);
            

            _carDal.Update(car);
            return new Result(true, Messages.CarUpdated);
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
