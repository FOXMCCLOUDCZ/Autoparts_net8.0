using AutopartsEntity.Catalog.ViewModels.ManufacturerViewmodel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.ManufacturerValidation
{
    public class ManufactureEditValidation : AbstractValidator<ManufacturerEditVM>
    {
        public ManufactureEditValidation()
        {
            RuleFor(x => x.TecDoc)
                .GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.GreaterThanMessage("TecDoc", 1))
                .LessThanOrEqualTo(999999).WithMessage(ValidationMessages.LessThanMessage("TecDoc", 999999));
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro název výrobce"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro název výrobce"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Název výrobce", 50));
            //RuleFor(x => x.LogoPath)
            RuleFor(x => x.Description)
                .MaximumLength(2000).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageFemale("Informace o výrobci", 2000));
        }
    }
}