using System.Text.Json.Serialization;

namespace Domain.Order.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order? Order { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product.Entities.Product? Product { get; set; }
        public int Quantity { get; set; }
    }
}
