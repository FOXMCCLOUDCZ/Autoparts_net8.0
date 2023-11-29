using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Engine : BaseEntity
    {
        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string EngineCode { get; set; } = null!;
        public bool IsActive { get; set; } = false;
        public ICollection<ParentPkwEngine>? ParentPkwEngines { get; set; }
    }
}