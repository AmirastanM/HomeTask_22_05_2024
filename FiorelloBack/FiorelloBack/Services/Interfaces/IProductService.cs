using FiorelloBack.Models;

namespace FiorelloBack.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdWhithAllDatasAsync(int id);
        Task<Product> GetByIdAsync(int id);
    }
}
