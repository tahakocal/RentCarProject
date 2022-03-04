using Business.Abstract;
using Business.Constants;
using Business.ValidationRules;
using Core.Aspect.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

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
        public IResult Add(Brand brand)
        {
            if (brand.Name.Length < 2)
            {
                return new ErrorResult(Messages.LenghtNotEnough);
            }
            _brandDal.Add(brand);
            return new Result(true, Messages.BrandAdded);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Delete(brand);
            return new Result(true, Messages.BrandUpdated);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Update(brand);
            return new Result(true, Messages.BrandDeleted);
        }
    }
}
