﻿using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using AutopartsService.Messages.Catalog;
using FluentValidation;

namespace AutopartsService.FluentValidation.Catalog.WarrantyValidation
{
    public class WarrantyEditValidation : AbstractValidator<WarrantyEditVM>
    {
        public WarrantyEditValidation()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage(ValidationMessages.NullEmptyMessage("pro název záruční lhůty"))
                .NotNull().WithMessage(ValidationMessages.NullEmptyMessage("pro název záruční lhůty"))
                .MaximumLength(50).WithMessage(ValidationMessages.MaximumCharacterAllowenceMessageFemale("Záruční lhůta", 50));
        }
    }
}