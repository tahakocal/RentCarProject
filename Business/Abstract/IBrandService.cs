
using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBrandService
    {
        DataResult<List<Brand>> GetAll();
        Result Add(Brand brand);
        Result Update(Brand brand);
        Result Delete(Brand brand);
    }
}
