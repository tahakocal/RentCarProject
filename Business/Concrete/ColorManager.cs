using System;
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
            if (car.Name.Length >= 2)
            {
                _colorDal.Add(car);
                Console.WriteLine(car.Id + " 'idli " + car.Name + " markasi sisteme basariyla eklendi!");
            }
            else
                Console.WriteLine("Renk ismi en az iki harfli olmalidir!");
        }

        public void Update(Color car)
        {
            _colorDal.Update(car);
            Console.WriteLine(car.Id + " 'idli " + car.Name + " rengi sistemde güncellendi!");
        }

        public void Delete(Color car)
        {
            _colorDal.Delete(car);
            Console.WriteLine(car.Id + " 'idli " + car.Name + " rengi sistemden silindi!");
        }
    }
}
