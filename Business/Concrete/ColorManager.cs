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
        public void Add(Color color)
        {
            if (color.Name.Length >= 2)
            {
                _colorDal.Add(color);
                Console.WriteLine(color.Id + " 'idli " + color.Name + " rengi sisteme basariyla eklendi!");
            }
            else
                Console.WriteLine("Renk ismi en az iki harfli olmalidir!");
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
            Console.WriteLine(color.Id + " 'idli " + color.Name + " rengi sistemde güncellendi!");
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
            Console.WriteLine(color.Id + " 'idli " + color.Name + " rengi sistemden silindi!");
        }
    }
}
