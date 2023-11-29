using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class OeNumberGroup : BaseEntity
    {
        public int OeId { get; set; }
        public Oe Oe { get; set; } = null!;
        public int OENumberInGroupId { get; set; }
    }
}