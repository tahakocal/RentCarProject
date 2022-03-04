using Core.Entities.Concrete;
using Core.Utilities.Result;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        User GetByMail(string email);

    }
}
