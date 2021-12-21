using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;

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
            throw new NotImplementedException();
        }

        public Result Update(User user)
        {
            throw new NotImplementedException();
        }

        public Result Delete(User user)
        {
            throw new NotImplementedException();
        }
    }
}
