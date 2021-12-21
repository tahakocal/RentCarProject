using System.Collections.Generic;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        Result Add(Customer customer);
        Result Delete(Customer customer);
        Result Update(Customer customer);

    }
}
