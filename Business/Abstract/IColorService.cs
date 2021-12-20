using System.Collections.Generic;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        DataResult<List<Color>> GetAll();
        Result Add(Color car);
        Result Update(Color car);
        Result Delete(Color car);
    }
}
