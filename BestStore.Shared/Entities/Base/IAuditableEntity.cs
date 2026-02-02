namespace BestStore.Shared.Entities.Base
{
    public interface IAuditableEntity
    {
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdatedAt { get; set; }
    }
}
