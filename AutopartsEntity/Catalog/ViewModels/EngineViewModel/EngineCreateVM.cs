using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.EngineViewModel
{
    public class EngineCreateVM
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string EngineCode { get; set; } = null!;
        public bool IsActive { get; set; } = false;
        public ICollection<ParentPkwEngine>? ParentPkwEngines { get; set; }
    }
}