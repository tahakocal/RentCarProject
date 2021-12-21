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
