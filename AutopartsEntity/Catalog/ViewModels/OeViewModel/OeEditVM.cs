using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeViewModel
{
    public class OeEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;
        public string OeNumber { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}