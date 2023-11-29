using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.EngineViewModel
{
    public class EngineEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string EngineCode { get; set; } = null!;
        public bool IsActive { get; set; } = false;
        public ICollection<ParentPkwEngine>? ParentPkwEngines { get; set; }
    }
}