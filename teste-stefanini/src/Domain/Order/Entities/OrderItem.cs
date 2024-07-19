namespace teste_stefanini.src.Domain.Order.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Domain.Product.Entities.Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
