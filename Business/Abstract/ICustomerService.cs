using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
