using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car()
                {
                    Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 450, ModelYear = 2018, Description = "Audi A8"
                },
                new Car()
                {
                    Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 500, ModelYear = 2019, Description = "Mercedes C180 "
                },
                new Car()
                {
                    Id = 3, BrandId = 3, ColorId = 3, DailyPrice = 850, ModelYear = 2020, Description = "BMW 420i"
                },
                new Car()
                {
                    Id = 4, BrandId = 4, ColorId = 4, DailyPrice = 2000, ModelYear = 2001, Description = "Nissan R34 GTR"
                },
                new Car()
                {
                    Id = 5, BrandId = 5, ColorId = 5, DailyPrice = 1500, ModelYear = 2021, Description = "BMW M4"
                }
            };

        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);   
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Description == car.Description);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c => c.Description == car.Description);

            _cars.Remove(carsToDelete);

        }
    }
}
