using OrchardCore.ContentManagement;
using Tweb.Product.Models;
using YesSql.Indexes;

namespace Tweb.Product.Indexes
{
    public class ProductPartIndex : MapIndex
    {
        public string ContentItemId { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class ProductPartIndexProvider : IndexProvider<ContentItem>
    {
        public override void Describe(DescribeContext<ContentItem> context)
        {
            context.For<ProductPartIndex>().Map(contentItem =>
            {
                var productPart = contentItem.As<ProductPart>();
                if (productPart == null)
                    return null;
                else
                    return new ProductPartIndex
                    {
                        ContentItemId = contentItem.ContentItemId,
                        UnitPrice = productPart.UnitPrice,
                    };
            });
        }
    }
}
