using AutopartsEntity.Catalog.ViewModels.CurrencyViewModel;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService _currencyService;
        private readonly IValidator<CurrencyCreateVM> _createValidator;
        private readonly IValidator<CurrencyEditVM> _editValidator;

        public CurrencyController(ICurrencyService currencyService, IValidator<CurrencyCreateVM> createValidator, IValidator<CurrencyEditVM> editValidator)
        {
            _currencyService = currencyService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        public async Task<IActionResult> CurrencyList()
        {
            var currencyList = await _currencyService.AllListAsync();
            return View(currencyList);
        }

        [HttpGet]
        public IActionResult CurrencyCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CurrencyCreate(CurrencyCreateVM request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _currencyService.CreateCurrencyAsync(request);
                return RedirectToAction("CurrencyList", "Currency", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CurrencyEdit(int id)
        {
            var currency = await _currencyService.GetCurrencyById(id);
            return View(currency);
        }

        [HttpPost]
        public async Task<IActionResult> CurrencyEdit(CurrencyEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _currencyService.EditCurrencyAsync(request);
                return RedirectToAction("CurrencyList", "Currency", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> CurrencyDelete(int id)
        {
            await _currencyService.DeleteCurrencyAsync(id);
            return RedirectToAction("CurrencyList", "Currency", new { Area = ("SuperAdmin") });
        }
    }
}