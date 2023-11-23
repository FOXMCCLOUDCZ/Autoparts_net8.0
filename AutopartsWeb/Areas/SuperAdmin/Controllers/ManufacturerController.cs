using AutopartsEntity.Catalog.ViewModels.ManufacturerViewmodel;
using AutopartsService.Services.Catalog.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class ManufacturerController : Controller
    {
        private readonly IManufacturerService _warrantyService;
        private readonly IValidator<ManufacturerCreateVM> _createValidator;
        private readonly IValidator<ManufacturerEditVM> _editValidator;

        public ManufacturerController(IManufacturerService warrantyService, IValidator<ManufacturerCreateVM> createValidator, IValidator<ManufacturerEditVM> editValidator)
        {
            _warrantyService = warrantyService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        public async Task<IActionResult> ManufacturerList()
        {
            var warrantyList = await _warrantyService.AllListAsync();
            return View(warrantyList);
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
                await _warrantyService.CreateManufacturerAsync(request);
                return RedirectToAction("ManufacturerList", "Manufacturer", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ManufacturerEdit(int id)
        {
            var warranty = await _warrantyService.GetManufacturerById(id);
            return View(warranty);
        }

        [HttpPost]
        public async Task<IActionResult> ManufacturerEdit(ManufacturerEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _warrantyService.EditManufacturerAsync(request);
                return RedirectToAction("ManufacturerList", "Manufacturer", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> ManufacturerDelete(int id)
        {
            await _warrantyService.DeleteManufacturerAsync(id);
            return RedirectToAction("ManufacturerList", "Manufacturer", new { Area = ("SuperAdmin") });
        }
    }
}