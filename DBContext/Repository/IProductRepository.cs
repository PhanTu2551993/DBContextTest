using DBContextTest.Models;

namespace DBContextTest.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task Add(Product pro);
        Task Update(Product pro);
        Task Delete(int id);
    }
}
