

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;

namespace MyMusic.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(MyMusicDbContext context)
            : base(context)
        { }


        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await MyMusicDbContext.Products.ToListAsync();
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await MyMusicDbContext.Products.FindAsync(id);
        }

        private MyMusicDbContext MyMusicDbContext
        {
            get { return Context as MyMusicDbContext; }
        }
    }
}