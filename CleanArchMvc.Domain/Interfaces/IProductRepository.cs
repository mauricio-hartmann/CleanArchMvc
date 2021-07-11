using CleanArchMvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetByIdAsync(int? id);
        Task<Product> GetProductByCategoryAsync(int? id);
        Task<Category> CreateAsync(Product category);
        Task<Category> UpdateAsync(Product category);
        Task<Category> RemoveAsync(Product category);
    }
}
