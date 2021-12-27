using FluentValidation;
using RestaurantApi.Models.Entity;

namespace RestaurantApi.Validators.Entity
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        static readonly int maxLength = 50;
    
        readonly string notNullMessage = "Bu Değerin Girilmesi Zorunludur.";
        readonly string maxLengthMessage = $"Bu Değer Max {maxLength} Uzunluğunda Olmalıdır.";

        public CustomerValidator()
        {
            RuleFor(x => x.FullName)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage)
                .MaximumLength(maxLength).WithMessage(maxLengthMessage);

            RuleFor(x => x.Table)
                .NotNull().WithMessage(notNullMessage)
                .NotEmpty().WithMessage(notNullMessage);

            RuleFor(x => x.ReservationTime)
                .NotEmpty().WithMessage(notNullMessage)
                .NotNull().WithMessage(notNullMessage);
        }
    }
}
