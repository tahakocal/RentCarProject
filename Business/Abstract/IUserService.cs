using System.Collections.Generic;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        Result Add(User user);
        Result Update(User user);
        Result Delete(User user);

    }
}
