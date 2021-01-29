using System.Collections.Generic;

namespace ECommerce.UI
{
    public class FeaturedProductsViewModel
    {
        public FeaturedProductsViewModel(
            IEnumerable<ProductViewModel> products)
        {
            this.Products = products;
        }
        public IEnumerable<ProductViewModel> Products { get; }
    }
}