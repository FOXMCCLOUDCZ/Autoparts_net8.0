using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class WarrantyController : Controller
    {
        private readonly IWarrantyService _warrantyService;
        private readonly IValidator<WarrantyCreateVM> _createValidator;
        private readonly IValidator<WarrantyEditVM> _editValidator;

        public WarrantyController(IWarrantyService warrantyService, IValidator<WarrantyCreateVM> createValidator, IValidator<WarrantyEditVM> editValidator)
        {
            _warrantyService = warrantyService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        public async Task<IActionResult> WarrantyList()
        {
            var warrantyList = await _warrantyService.AllListAsync();
            return View(warrantyList);
        }

        [HttpGet]
        public IActionResult WarrantyCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> WarrantyCreate(WarrantyCreateVM request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _warrantyService.CreateWarrantyAsync(request);
                return RedirectToAction("WarrantyList", "Warranty", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> WarrantyEdit(int id)
        {
            var warranty = await _warrantyService.GetWarrantyById(id);
            return View(warranty);
        }

        [HttpPost]
        public async Task<IActionResult> WarrantyEdit(WarrantyEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _warrantyService.EditWarrantyAsync(request);
                return RedirectToAction("WarrantyList", "Warranty", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> WarrantyDelete(int id)
        {
            await _warrantyService.DeleteWarrantyAsync(id);
            return RedirectToAction("WarrantyList", "Warranty", new { Area = ("SuperAdmin") });
        }
    }
}