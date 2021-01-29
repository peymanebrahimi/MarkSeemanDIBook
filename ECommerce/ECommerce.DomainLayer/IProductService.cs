using System.Collections.Generic;

namespace ECommerce.DomainLayer
{
    public interface IProductService
    {
        IEnumerable<DiscountedProduct> GetFeaturedProducts();
    }
}