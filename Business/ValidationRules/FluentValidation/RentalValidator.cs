using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.ReturnDate).NotNull();
        }
    }
}
