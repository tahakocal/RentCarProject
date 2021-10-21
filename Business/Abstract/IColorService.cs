using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();

        void Add(Color car);
        void Update(Color car);
        void Delete(Color car);
    }
}
