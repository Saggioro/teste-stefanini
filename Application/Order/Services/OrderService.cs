



using Application.Order.Interfaces;
using Domain.Order.Interfaces;

namespace Application.Order.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<IEnumerable<Domain.Order.Entities.Order>> GetAllAsync()
        {
            return await _orderRepository.GetAllAsync();
        }

        public async Task<Domain.Order.Entities.Order> GetByIdAsync(int id)
        {
            return await _orderRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Domain.Order.Entities.Order order)
        {
            await _orderRepository.AddAsync(order);
        }

        public async Task UpdateAsync(Domain.Order.Entities.Order order)
        {
            await _orderRepository.UpdateAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }
    }
}
