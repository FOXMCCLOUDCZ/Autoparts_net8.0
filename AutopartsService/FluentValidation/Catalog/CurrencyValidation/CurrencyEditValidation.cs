using AutopartsEntity.Catalog.ViewModels.CurrencyViewModel;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.CurrencyValidation
{
    public class CurrencyEditValidation : AbstractValidator<CurrencyEditVM>
    {
        public CurrencyEditValidation()
        {
            RuleFor(x => x.NumericCurrencyCode)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(999);
            RuleFor(x => x.CurrencyCode)
                .NotEmpty()
                .NotNull()
                .MaximumLength(3);
            RuleFor(x => x.CurrencyName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
        }
    }
}