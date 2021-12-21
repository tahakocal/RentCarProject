using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Business.Constants;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

      

        public Result Add(User user)
        {
            if (user.FirstName.Length < 2)
            {
                return new ErrorResult(Messages.LenghtNotEnough);

            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public Result Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public Result Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult( Messages.UserDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

    }
}
