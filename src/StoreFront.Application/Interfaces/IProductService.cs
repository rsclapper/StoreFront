using System.Collections.Generic;
using System.Threading.Tasks;
using StoreFront.Application.DTOs;

namespace StoreFront.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync(int id);
        Task<ProductDto> CreateProductAsync(ProductDto product);
        Task UpdateProductAsync(int id, ProductDto product);
        Task DeleteProductAsync(int id);
    }
}