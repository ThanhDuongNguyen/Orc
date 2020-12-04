using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Tweb.Product.Models;

namespace Tweb.Product.ViewModels
{
    public class ProductPartViewModel
    {
        [Required]
        public string Sku { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [BindNever]
        public ProductPart ProductPart { get; set; }
    }
}
