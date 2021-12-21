﻿using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

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
