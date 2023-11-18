using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.WarrantyValidation
{
    public class WarrantyCreateValidation : AbstractValidator<WarrantyCreateVM>
    {
        public WarrantyCreateValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);
        }
    }
}