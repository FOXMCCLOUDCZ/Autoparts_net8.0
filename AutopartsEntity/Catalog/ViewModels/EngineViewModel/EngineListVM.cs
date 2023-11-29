using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.EngineViewModel
{
    public class EngineListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string EngineCode { get; set; } = null!;
        public bool IsActive { get; set; } = false;
        public ICollection<ParentPkwEngine>? ParentPkwEngines { get; set; }
    }
}