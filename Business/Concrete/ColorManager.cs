using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color car)
        {
            _colorDal.Add(car);
        }

        public void Update(Color car)
        {
            _colorDal.Update(car);
        }

        public void Delete(Color car)
        {
            _colorDal.Delete(car);
        }
    }
}
