using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using Business.ValidationRules;
using Core.Aspect.Autofac.Validation;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.BrandListed);
        }

        [ValidationAspect(typeof(BrandValidator))]
        public Result Add(Brand brand)
        {
            if (brand.Name.Length < 2)
            {
                return new ErrorResult(Messages.LenghtNotEnough);
            }
            _brandDal.Add(brand);
            return new Result(true, Messages.BrandAdded);
        }

        public Result Update(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true, Messages.BrandUpdated);
        }

        public Result Delete(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, Messages.BrandDeleted);
        }
    }
}
