using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        Result Add(Rental rental);
        Result Update(Rental rental);
        Result Delete(Rental rental);
    }
}
