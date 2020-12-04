using System;
using System.Collections.Generic;
using System.Text;
using OrchardCore.ContentManagement;

namespace Tweb.Product.Models
{
    public class ProductPart : ContentPart
    {
        public decimal UnitPrice { get; set; }
        public string Sku { get; set; }
    }
}
