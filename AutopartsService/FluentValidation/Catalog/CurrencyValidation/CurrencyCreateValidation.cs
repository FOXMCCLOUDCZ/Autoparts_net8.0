using AutopartsEntity.Catalog.ViewModels.CurrencyViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.CurrencyValidation
{
    public class CurrencyCreateValidation : AbstractValidator<CurrencyCreateVM>
    {
        public CurrencyCreateValidation()
        {
            RuleFor(x => x.NumericCurrencyCode)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro číselný kód měny"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro číselný kód měny"))
                .GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.GreaterThanMessage("číselného kódu měny", 1))
                .LessThanOrEqualTo(999).WithMessage(ValidationMessages.LessThanMessage("číselného kódu měny", 999));
            RuleFor(x => x.CurrencyCode)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro kód měny"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro kód měny"))
                .MaximumLength(3).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Kód měny", 3));
            RuleFor(x => x.CurrencyName)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro název měny"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro název měny"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Název měny", 50));
        }
    }
}