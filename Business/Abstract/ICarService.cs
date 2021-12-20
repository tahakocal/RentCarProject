using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ICarService
    {
        Result Add(Car car);
        Result Delete(Car car);
        Result Update(Car car);
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
    }
}
