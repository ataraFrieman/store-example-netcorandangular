

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
            return await MyMusicDbContext.Products
            .Include(p => p.ProductBrand)
            .Include(p => p.ProductType)
            .ToListAsync();
        }


        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await MyMusicDbContext.Products
             .Include(p => p.ProductBrand)
            .Include(p => p.ProductType)
            .FirstOrDefaultAsync(p => p.Id == id);
        }

       public async Task<IEnumerable<ProductBrand>> GetProductBrandsAsync()
        {
            return await MyMusicDbContext.ProductBrands.ToListAsync();
        }

        public async Task<IEnumerable<ProductType>> GetProductTypesAsync()
        {
            return await MyMusicDbContext.ProductTypes.ToListAsync();
        }

        private MyMusicDbContext MyMusicDbContext
        {
            get { return Context as MyMusicDbContext; }
        }
    }
}