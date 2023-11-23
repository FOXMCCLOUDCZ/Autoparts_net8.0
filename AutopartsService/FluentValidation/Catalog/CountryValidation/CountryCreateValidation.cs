using AutopartsEntity.Catalog.ViewModels.CountryViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.CountryValidation
{
    public class CountryCreateValidation : AbstractValidator<CountryCreateVM>
    {
        public CountryCreateValidation()
        {
            RuleFor(x => x.NumericCountryCode)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro číselný kód země"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro číselný kód země"))
                .GreaterThanOrEqualTo(1).WithMessage(ValidationMessages.GreaterThanMessage("číselného kódu země", 1))
                .LessThanOrEqualTo(999).WithMessage(ValidationMessages.LessThanMessage("číselného kódu země", 999));
            RuleFor(x => x.ISOAlpha2)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro ISOAlpha2"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro ISOAlpha2"))
                .MaximumLength(2).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMiddle("ISOAlpha2", 2));
            RuleFor(x => x.ISOAlpha3)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro ISOAlpha3"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro ISOAlpha3"))
                .MaximumLength(3).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMiddle("ISOAlpha2", 3));
            RuleFor(x => x.CountryNameCZ)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro český název země"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro český název země"))
                .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Český název země", 100));
            RuleFor(x => x.CountryNameENG)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro anglický název země"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro anglický název země"))
                .MaximumLength(100).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageMale("Anglický název země", 100));
            RuleFor(x => x.CurrencyId)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessageSelect("měnu pro tuto zemi"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessageSelect("měnu pro tuto zemi"));
        }
    }
}