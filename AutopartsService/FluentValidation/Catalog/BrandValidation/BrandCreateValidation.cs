using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.BrandValidation
{
    public class BrandCreateValidation : AbstractValidator<BrandCreateVM>
    {
        public BrandCreateValidation()
        {
            RuleFor(x => x.TecDoc)
                .GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.GreaterThanMessage("TecDoc", 1))
                .LessThanOrEqualTo(999999).WithMessage(ValidationMessages.LessThanMessage("TecDoc", 999999));
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro název Brandu"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro název Brandu"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Název Brandu", 50));
            //RuleFor(x => x.LogoPath)
            RuleFor(x => x.GeneralInformation)
                .MaximumLength(2000).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageFemale("Informace o Brandu", 2000));
        }
    }
}