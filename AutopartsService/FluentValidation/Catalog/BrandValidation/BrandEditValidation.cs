using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.BrandValidation
{
    public class BrandEditValidation : AbstractValidator<BrandCreateVM>
    {
        public BrandEditValidation()
        {
            RuleFor(x => x.TecDoc)
                .GreaterThanOrEqualTo(1)
                .LessThanOrEqualTo(999999);
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
            RuleFor(x => x.LogoPath);
            RuleFor(x => x.GeneralInformation)
                .MaximumLength(2000);
        }
    }
}