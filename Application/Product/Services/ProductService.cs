﻿using Application.Product.Interfaces;
using Domain.Product.Interfaces;

namespace Application.Product.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Domain.Product.Entities.Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Domain.Product.Entities.Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Domain.Product.Entities.Product product)
        {
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateAsync(Domain.Product.Entities.Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }
    }
}
