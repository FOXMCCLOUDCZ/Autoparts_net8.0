namespace AutopartsEntity.Catalog.Entities
{
    public class ParentPkwEngine
    {
        public int PkwId { get; set; }
        public Pkw Pkw { get; set; } = null!;
        public int EngineId { get; set; }
        public Engine Engine { get; set; } = null!;
    }
}