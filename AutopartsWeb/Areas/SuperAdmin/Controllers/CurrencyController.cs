using AutopartsEntity.Catalog.ViewModels.CurrencyViewModel;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class CurrencyController : Controller
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
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
            await _currencyService.CreateCurrencyAsync(request);
            return RedirectToAction("CurrencyList", "Currency", new { Area = ("SuperAdmin") });
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
            await _currencyService.EditCurrencyAsync(request);
            return RedirectToAction("CurrencyList", "Currency", new { Area = ("SuperAdmin") });
        }

        public async Task<IActionResult> CurrencyDelete(int id)
        {
            await _currencyService.DeleteCurrencyAsync(id);
            return RedirectToAction("CurrencyList", "Currency", new { Area = ("SuperAdmin") });
        }
    }
}