using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IValidator<BrandCreateVM> _createValidator;
        private readonly IValidator<BrandEditVM> _editValidator;

        public BrandController(IBrandService brandService, IValidator<BrandCreateVM> createValidator, IValidator<BrandEditVM> editValidator)
        {
            _brandService = brandService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        public async Task<IActionResult> BrandList()
        {
            var brandList = await _brandService.AllListAsync();
            return View(brandList);
        }

        [HttpGet]
        public IActionResult BrandCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BrandCreate(BrandCreateVM request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _brandService.CreateBrandAsync(request);
                return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> BrandEdit(int id)
        {
            var brand = await _brandService.GetBrandById(id);
            return View(brand);
        }

        [HttpPost]
        public async Task<IActionResult> BrandEdit(BrandEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _brandService.EditBrandAsync(request);
                return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> BrandDelete(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
        }
    }
}