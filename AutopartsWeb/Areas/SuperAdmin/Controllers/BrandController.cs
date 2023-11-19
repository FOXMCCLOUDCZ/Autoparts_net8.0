using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public async Task<IActionResult> BrandList()
        {
            var brandList = await _brandService.AllListAsync();
            return View(brandList);
        }

        [HttpGet]
        public async Task<IActionResult> BrandCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BrandCreate(BrandCreateVM request)
        {
            await _brandService.CreateBrandAsync(request);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
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
            await _brandService.EditBrandAsync(request);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
        }

        public async Task<IActionResult> BrandDelete(int id)
        {
            await _brandService.DeleteBrandAsync(id);
            return RedirectToAction("BrandList", "Brand", new { Area = ("SuperAdmin") });
        }
    }
}