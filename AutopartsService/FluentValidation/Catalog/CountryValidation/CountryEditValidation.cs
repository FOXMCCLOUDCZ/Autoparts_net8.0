using AutopartsEntity.Catalog.ViewModels.CountryViewModel;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.CountryValidation
{
    public class CountryEditValidation : AbstractValidator<CountryEditVM>
    {
        public CountryEditValidation()
        {
            {
                RuleFor(x => x.NumericCountryCode)
                    .NotEmpty()
                    .NotNull()
                    .GreaterThanOrEqualTo(1)
                    .LessThanOrEqualTo(999);
                RuleFor(x => x.ISOAlpha2)
                    .NotEmpty()
                    .NotNull()
                    .MaximumLength(2);
                RuleFor(x => x.ISOAlpha3)
                    .NotEmpty()
                    .NotNull()
                    .MaximumLength(3);
                RuleFor(x => x.CountryNameCZ)
                    .NotEmpty()
                    .NotNull()
                    .MaximumLength(100);
                RuleFor(x => x.CountryNameENG)
                    .NotEmpty()
                    .NotNull()
                    .MaximumLength(100);
                RuleFor(x => x.CurrencyId)
                    .NotEmpty()
                    .NotNull();
            }
        }
    }
}