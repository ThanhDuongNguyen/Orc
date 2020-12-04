using System.Threading.Tasks;
using OrchardCore.ContentManagement.Handlers;
using Tweb.Product.Models;

namespace Tweb.Product.Handlers
{
    public class ProductPartHandler : ContentPartHandler<ProductPart>
    {
        public ProductPartHandler()
        {

        }

        public override Task UpdatedAsync(UpdateContentContext context, ProductPart instance)
        {
            return Task.CompletedTask;
        }
    }
}
