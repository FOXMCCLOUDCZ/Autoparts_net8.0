using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel
{
    public class OeNumberGroupCreateVM
    {
        public int OENumberInGroupId { get; set; }
        public int OeId { get; set; }
        public Oe Oe { get; set; } = null!;
    }
}