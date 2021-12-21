using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public Result Add(Rental rental)
        {
            throw new NotImplementedException();
        }

        public Result Update(Rental rental)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
