using AutopartsEntity.Catalog.ViewModels.ModelViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class ModelController : Controller
    {
        private readonly IModelService _modelService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IValidator<ModelCreateVM> _createValidator;
        private readonly IValidator<ModelEditVM> _editValidator;

        public ModelController(IModelService modelService, IManufacturerService manufacturerService, IValidator<ModelCreateVM> createValidator, IValidator<ModelEditVM> editValidator)
        {
            _modelService = modelService;
            _manufacturerService = manufacturerService;
            _createValidator = createValidator;
            _editValidator = editValidator;
        }

        private SelectList GetActiveManufacturers()
        {
            var allManufacturers = _manufacturerService.AllListAsync().Result;
            var activeManufacturers = allManufacturers.Where(ma => ma.IsAutoParts == false && ma.IsActive == true).ToList();
            return new SelectList(activeManufacturers, "Id", "ManufacturerName");
        }

        public async Task<IActionResult> ModelList()
        {
            var modelList = await _modelService.AllListAsync();
            return View(modelList);
        }

        [HttpGet]
        public IActionResult ModelCreate()
        {
            ViewData["Manufacturer"] = GetActiveManufacturers();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ModelCreate(ModelCreateVM request)
        {
            var validation = await _createValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _modelService.CreateModelAsync(request);
                return RedirectToAction("ModelList", "Model", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ModelEdit(int id)
        {
            var model = await _modelService.GetModelById(id);
            ViewData["Manufacturer"] = GetActiveManufacturers();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ModelEdit(ModelEditVM request)
        {
            var validation = await _editValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _modelService.EditModelAsync(request);
                return RedirectToAction("ModelList", "Model", new { Area = ("SuperAdmin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        public async Task<IActionResult> ModelDelete(int id)
        {
            await _modelService.DeleteModelAsync(id);
            return RedirectToAction("ModelList", "Model", new { Area = ("SuperAdmin") });
        }
    }
}