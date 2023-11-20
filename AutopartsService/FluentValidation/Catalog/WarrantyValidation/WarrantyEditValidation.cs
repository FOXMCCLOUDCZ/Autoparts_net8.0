using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.WarrantyValidation
{
    public class WarrantyEditValidation : AbstractValidator<WarrantyEditVM>
    {
        public WarrantyEditValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessageTitle("záruční lhůty"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessageTitle("záruční lhůty"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageTitle("Záruční lhůta",50));
        }
    }
}