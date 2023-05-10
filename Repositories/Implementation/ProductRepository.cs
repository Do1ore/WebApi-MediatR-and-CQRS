using CleanWebAPI.Models.Context;
using CleanWebAPI.Models.MainModels;
using CleanWebAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace CleanWebAPI.Repositories.Implementation
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyPetContext _db;
        public ProductRepository(MyPetContext db)
        {
            _db = db;
        }
        public async Task<Product> AddProduct(Product product)
        {
            if (product == null)
            {
                return new Product();
            }
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return product;

        }

        public async Task<int> DeleteProductAsync(int id)
        {
            var product = await _db.Products.FindAsync(id);
            _db.Products.Remove(product);
            return await _db.SaveChangesAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            var product = await _db.Products.FindAsync(id);
            return product;
        }

        public async Task<List<Product>> GetProductListAsync()
        {
            return await _db.Products.AsNoTracking().ToListAsync();
        }

        public bool IsExists(int id)
        {
            return _db.Products.AsNoTracking().Any(p => p.Id == id);
        }

        public async Task<int> UpdateProductAsync(Product product)
        {
            _db.Products.Update(product);
            return await _db.SaveChangesAsync();
        }
    }
}
