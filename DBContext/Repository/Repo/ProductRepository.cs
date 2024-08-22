using DBContextTest.Data;
using DBContextTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DBContextTest.Repository.Repo
{
    public class ProductRepository : IProductRepository
    {
        private readonly DbContextTest _context;

        public ProductRepository(DbContextTest context)
        {
            _context = context;
        }
        public async Task Add(Product pro)
        {
             await _context.Products.AddAsync(pro);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
           return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task Update(Product pro)
        {
            _context.Products.Update(pro);
            await _context.SaveChangesAsync();
        }
    }
}
