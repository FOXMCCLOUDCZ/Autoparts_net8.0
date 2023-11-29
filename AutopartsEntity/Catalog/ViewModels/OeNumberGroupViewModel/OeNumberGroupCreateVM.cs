using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel
{
    public class OeNumberGroupCreateVM
    {
        public int OeId { get; set; }
        public Oe Oe { get; set; } = null!;
        public int OENumberInGroupId { get; set; }
    }
}