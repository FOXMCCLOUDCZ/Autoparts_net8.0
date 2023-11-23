using AutopartsEntity.Catalog.ViewModels.CountryViewModel;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class CountryController : Controller
    {
        private readonly ICountryService _countryService;
        private readonly ICurrencyService _currencyService;
        private readonly IValidator<CountryCreateVM> _createValidator;
        private readonly IValidator<CountryEditVM> _editValidator;

        public CountryController(ICountryService countryService, ICurrencyService currencyService, IValidator<CountryCreateVM> createValidator, IValidator<CountryEditVM> editValidator)
        {
            _countryService = countryService;
            _currencyService = currencyService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        private SelectList GetActiveCurrencies()
        {
            var allCurrencies = _currencyService.AllListAsync().Result;
            var activeCurrencies = allCurrencies.Where(cu => cu.IsActive).ToList();
            return new SelectList(activeCurrencies, "Id", "CurrencyName");
        }

        public async Task<IActionResult> CountryList()
        {
            var countryList = await _countryService.AllListAsync();
            return View(countryList);
        }

        [HttpGet]
        public IActionResult CountryCreate()
        {
            ViewData["Currency"] = GetActiveCurrencies();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CountryCreate(CountryCreateVM request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _countryService.CreateCountryAsync(request);
                return RedirectToAction("CountryList", "Country", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CountryEdit(int id)
        {
            var country = await _countryService.GetCountryById(id);
            ViewData["Currency"] = GetActiveCurrencies();
            return View(country);
        }

        [HttpPost]
        public async Task<IActionResult> CountryEdit(CountryEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _countryService.EditCountryAsync(request);
                return RedirectToAction("CountryList", "Country", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> CountryDelete(int id)
        {
            await _countryService.DeleteCountryAsync(id);
            return RedirectToAction("CountryList", "Country", new { Area = ("SuperAdmin") });
        }
    }
}