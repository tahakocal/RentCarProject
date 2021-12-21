using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public Result Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Result Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
