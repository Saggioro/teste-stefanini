namespace Domain.Order.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product.Entities.Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
