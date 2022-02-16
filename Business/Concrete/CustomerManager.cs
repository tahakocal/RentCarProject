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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        [ValidationAspect(typeof(CustomerValidator))]
        public Result Add(Customer customer)
        {
            if (customer.CompanyName.Length <= 2)
            {
                return new ErrorResult(Messages.LenghtNotEnough);
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);

        }

        public Result Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public Result Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
