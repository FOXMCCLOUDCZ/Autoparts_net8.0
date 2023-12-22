using AutopartsEntity.Catalog.Entities;

namespace AutopartsEntity.Catalog.ViewModels.OeNumberGroupViewModel
{
    public class OeNumberGroupEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public int OENumberInGroupId { get; set; }
        public int OeId { get; set; }
        public Oe Oe { get; set; } = null!;
    }
}