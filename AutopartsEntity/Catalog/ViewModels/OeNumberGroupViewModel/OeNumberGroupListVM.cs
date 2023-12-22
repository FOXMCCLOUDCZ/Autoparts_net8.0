using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel
{
    public class OeNumberGroupListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public int OENumberInGroupId { get; set; }
        public int OeId { get; set; }
        public Oe Oe { get; set; } = null!;
    }
}