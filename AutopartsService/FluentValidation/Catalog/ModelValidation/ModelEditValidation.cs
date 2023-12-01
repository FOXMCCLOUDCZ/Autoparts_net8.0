using AutopartsEntity.Catalog.ViewModels.ModelViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.ModelValidation
{
    public class ModelEditValidation : AbstractValidator<ModelEditVM>
    {
        public ModelEditValidation()
        {
            RuleFor(x => x.ManufacturerId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro výrobce"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro výrobce"));
            RuleFor(x => x.ModelName)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro model vozidla"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro model vozidla"))
                .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Název modelu vozidla", 100));
            RuleFor(x => x.MadeBy)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro začátek výroby modelu"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro začátek výroby modelu"));
            RuleFor(x => x.MadeTo)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro konec výroby modelu"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro konec výroby modelu"));
        }
    }
}