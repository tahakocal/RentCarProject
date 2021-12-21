using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Result Add(Customer customer);
        Result Delete(Customer customer);
        Result Update(Customer customer);

    }
}
