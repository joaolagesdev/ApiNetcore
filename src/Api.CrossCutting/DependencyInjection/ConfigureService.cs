using Domain.Interfaces.Services.ItemsSolicitation;
using Domain.Interfaces.Services.Product;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProductService, ProductService>();
            serviceCollection.AddTransient<IItemsSolicitationService, ItemsSolicitationService>();
        }
    }
}
