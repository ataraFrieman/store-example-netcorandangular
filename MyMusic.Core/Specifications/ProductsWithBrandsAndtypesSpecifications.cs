using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MyMusic.Core.Models;

namespace MyMusic.Core.Specifications
{
    public class ProductsWithBrandsAndtypesSpecifications : BaseSpecification<Product>
    {
        public ProductsWithBrandsAndtypesSpecifications()
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }

        public ProductsWithBrandsAndtypesSpecifications(Expression<Func<Product, bool>> q ) : base(q)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}