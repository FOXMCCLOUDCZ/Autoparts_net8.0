using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeViewModel
{
    public class OeListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string OeNumber { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}