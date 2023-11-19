﻿using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using AutopartsService.Services.Catalog.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutopartsWeb.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class WarrantyController : Controller
    {
        private readonly IWarrantyService _warrantyService;

        public WarrantyController(IWarrantyService warrantyService)
        {
            _warrantyService = warrantyService;
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
            await _warrantyService.CreateWarrantyAsync(request);
            return RedirectToAction("WarrantyList", "Warranty", new { Area = ("SuperAdmin") });
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
            await _warrantyService.EditWarrantyAsync(request);
            return RedirectToAction("WarrantyList", "Warranty", new { Area = ("SuperAdmin") });
        }

        public async Task<IActionResult> WarrantyDelete(int id)
        {
            await _warrantyService.DeleteWarrantyAsync(id);
            return RedirectToAction("WarrantyList", "Warranty", new { Area = ("SuperAdmin") });
        }
    }
}