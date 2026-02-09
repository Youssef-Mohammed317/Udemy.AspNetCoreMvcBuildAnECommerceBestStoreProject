using BestStore.Shared.Entities.Base;

namespace BestStore.Shared.Entities
{
    public class OrderItem : BaseEntity
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
