using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        Result Add(Rental rental);
        Result Update(Rental rental);
        Result Delete(Rental rental);
    }
}
