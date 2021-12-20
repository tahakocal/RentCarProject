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
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
    }
}
