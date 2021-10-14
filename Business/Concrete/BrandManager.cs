using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine(brand.Id + " 'idli " + brand.Name + " markasi sisteme basariyla eklendi!");
            }
            else
                Console.WriteLine("Marka ismi en az iki harfli olmalidir!");
        }

        public void Update(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine(brand.Id + " 'idli " + brand.Name + " markasi sistemden silindi!");
        }

        public void Delete(Brand brand)
        {
            _brandDal.Update(brand);
            Console.WriteLine(brand.Id + " 'idli marka bilgileri guncellendi!");
        }
    }
}
