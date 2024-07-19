namespace Domain.Order.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Paid { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}

