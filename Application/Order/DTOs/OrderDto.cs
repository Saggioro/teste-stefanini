using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Order.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Paid { get; set; }
        public ICollection<OrderItemDto> OrderItems { get; set; }
    }
}
