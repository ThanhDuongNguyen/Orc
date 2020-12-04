using System.Threading.Tasks;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.ModelBinding;
using OrchardCore.DisplayManagement.Views;
using Tweb.Product.Models;
using Tweb.Product.ViewModels;

namespace Tweb.Product.Drivers
{
    public class ProductPartDriver : ContentPartDisplayDriver<ProductPart>
    {
        public override IDisplayResult Display(ProductPart part, BuildPartDisplayContext context)
        {
            return Initialize<ProductPartViewModel>(GetDisplayShapeType(context), viewModel =>
            {
                viewModel.Sku = part.Sku;
                viewModel.UnitPrice = part.UnitPrice;
                viewModel.ProductPart = part;
            })
                .Location("Detail", "Content:1")
                .Location("Summary", "Content:1"); ;
        }


        //Edit View
        public override IDisplayResult Edit(ProductPart part, BuildPartEditorContext context)
        {
            return Initialize<ProductPartViewModel>(GetEditorShapeType(context), viewModel =>
            {
                viewModel.Sku = part.Sku;
                viewModel.UnitPrice = part.UnitPrice;
                viewModel.ProductPart = part;
            });
        }

        //Update
        public async override Task<IDisplayResult> UpdateAsync(ProductPart part, IUpdateModel updater, UpdatePartEditorContext context)
        {
            var viewModel = new ProductPartViewModel();
            await updater.TryUpdateModelAsync(viewModel, Prefix);
            part.UnitPrice = viewModel.UnitPrice;
            part.Sku = viewModel.Sku;
            return await EditAsync(part, context);
        }
    }
}
