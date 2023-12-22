using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class OeNumberGroup : BaseEntity
    {
        public int OeNumberInGroupId { get; set; }
        public int OeId { get; set; }
        public Oe Oe { get; set; } = null!;
    }
}