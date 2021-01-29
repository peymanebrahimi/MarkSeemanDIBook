using System.Collections.Generic;

namespace ECommerce.DomainLayer
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetFeaturedProducts();
    }
}