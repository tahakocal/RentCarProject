﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

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
