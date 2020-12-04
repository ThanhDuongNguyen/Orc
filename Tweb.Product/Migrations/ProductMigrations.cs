using System;
using System.Collections.Generic;
using System.Text;
using OrchardCore.Apis.GraphQL;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;
using Tweb.Product.Indexes;

namespace Tweb.Product.Migrations
{
    public class ProductMigrations : DataMigration
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public ProductMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinition("ProductPart", part => part.Attachable());

            SchemaBuilder.CreateMapIndexTable("ProductPartIndex", table => table
            .Column<string>(nameof(ProductPartIndex.ContentItemId), column => column.WithLength(26))
            .Column<decimal>(nameof(ProductPartIndex.UnitPrice))
            );
            
            return 1;
        }
    }
}
