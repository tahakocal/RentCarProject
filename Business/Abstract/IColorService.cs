using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        Result Add(Color color);
        Result Update(Color color);
        Result Delete(Color color);
    }
}
