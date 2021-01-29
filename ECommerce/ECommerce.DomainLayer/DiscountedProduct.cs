using System;

namespace ECommerce.DomainLayer
{
    public class DiscountedProduct
    {
        public DiscountedProduct(string name, decimal unitPrice)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            UnitPrice = unitPrice;
        }


        public string Name { get; }
        public decimal UnitPrice { get; }
    }
}
