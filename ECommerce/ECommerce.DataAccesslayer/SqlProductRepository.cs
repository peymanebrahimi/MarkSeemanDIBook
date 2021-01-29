using System;
using System.Linq;
using System.Collections.Generic;
using ECommerce.DomainLayer;

namespace ECommerce.DataAccesslayer
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly CommerceContext _context;

        public SqlProductRepository(CommerceContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Product> GetFeaturedProducts()
        {
            return
                from product in _context.Products
                where product.IsFeatured
                select product;
        }
    }
}
