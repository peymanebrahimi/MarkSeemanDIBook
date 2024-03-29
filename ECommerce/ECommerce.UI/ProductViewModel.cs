﻿using System.Globalization;

namespace ECommerce.UI
{
    public class ProductViewModel
    {
        private static readonly CultureInfo PriceCulture = new CultureInfo("en-US");
        public ProductViewModel(string name, decimal unitPrice)
        {
            SummaryText = string.Format(PriceCulture, "{0} ({1:C})", name, unitPrice);
        }
        
        public string SummaryText { get; }
    }
}