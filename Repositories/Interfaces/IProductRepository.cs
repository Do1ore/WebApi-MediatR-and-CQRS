using CleanWebAPI.Models.MainModels;

namespace CleanWebAPI.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProductListAsync();
        public Task<Product?> GetProductByIdAsync(int id);
        public Task<Product> AddProduct(Product product);
        public Task<int> UpdateProductAsync(Product product);
        public Task<int> DeleteProductAsync(int id);

        public bool IsExists(int id);
    }
}
