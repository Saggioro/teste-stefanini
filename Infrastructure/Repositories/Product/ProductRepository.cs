﻿using Microsoft.EntityFrameworkCore;
using Domain.Product.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories.Product
{
    public class ProductRepository: IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Domain.Product.Entities.Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Domain.Product.Entities.Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Domain.Product.Entities.Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Domain.Product.Entities.Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }
    }
}
