using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.WarrantyValidation
{
    public class WarrantyCreateValidation : AbstractValidator<WarrantyCreateVM>
    {
        public WarrantyCreateValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessageTitle("záruční lhůty"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessageTitle("záruční lhůty"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageTitle("záruční lhůty",50));
        }
    }
}