using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
