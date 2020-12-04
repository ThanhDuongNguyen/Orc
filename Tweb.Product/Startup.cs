using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;
using Tweb.Product.Drivers;
using Tweb.Product.Handlers;
using Tweb.Product.Indexes;
using Tweb.Product.Migrations;
using Tweb.Product.Models;
using YesSql.Indexes;

namespace Tweb.Product
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddContentPart<ProductPart>()
                .UseDisplayDriver<ProductPartDriver>()
                .AddHandler<ProductPartHandler>();
            services.AddScoped<IDataMigration, ProductMigrations>();
            services.AddSingleton<IIndexProvider, ProductPartIndexProvider>();
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
           
        }
    }
}
