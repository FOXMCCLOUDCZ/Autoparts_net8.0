using AutopartsEntity.Catalog.ViewModels.ManufacturerViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IValidator<ManufacturerCreateVM> _createValidator;
        private readonly IValidator<ManufacturerEditVM> _editValidator;

        public ManufacturerController(IManufacturerService manufacturerService, IValidator<ManufacturerCreateVM> createValidator, IValidator<ManufacturerEditVM> editValidator)
        {
            _manufacturerService = manufacturerService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        public async Task<IActionResult> ManufacturerList()
        {
            var manufacturerList = await _manufacturerService.AllListAsync();
            return View(manufacturerList);
        }

        [HttpGet]
        public IActionResult ManufacturerCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ManufacturerCreate(ManufacturerCreateVM request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _manufacturerService.CreateManufacturerAsync(request);
                return RedirectToAction("ManufacturerList", "Manufacturer", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ManufacturerEdit(int id)
        {
            var manufacturer = await _manufacturerService.GetManufacturerById(id);
            return View(manufacturer);
        }

        [HttpPost]
        public async Task<IActionResult> ManufacturerEdit(ManufacturerEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _manufacturerService.EditManufacturerAsync(request);
                return RedirectToAction("ManufacturerList", "Manufacturer", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> ManufacturerDelete(int id)
        {
            await _manufacturerService.DeleteManufacturerAsync(id);
            return RedirectToAction("ManufacturerList", "Manufacturer", new { Area = ("SuperAdmin") });
        }
    }
}