using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeViewModel
{
    public class OeCreateVM
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string OeNumber { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}