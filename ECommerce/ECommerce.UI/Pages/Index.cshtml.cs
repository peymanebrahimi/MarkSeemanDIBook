using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.DomainLayer;

namespace ECommerce.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProductService _productService;

        public IndexModel(ILogger<IndexModel> logger,
            IProductService productService)
        {
            _logger = logger;
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public void OnGet()
        {
            IEnumerable<DiscountedProduct> products =
                _productService.GetFeaturedProducts();
            
            var vm = new FeaturedProductsViewModel(
                from product in products
                select new ProductViewModel(product.Name, product.UnitPrice));
        }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
}
