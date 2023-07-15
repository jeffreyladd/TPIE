using Microsoft.Extensions.Configuration;
using TPIE;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Extension Method to setup all the TPIE Dependencies.
    /// </summary>
    /// <param name="services">The Service Collection for DI.</param>
    /// <param name="config">The configuration.</param>
    /// <returns></returns>
    public static IServiceCollection SetupTPIE(this IServiceCollection services, IConfiguration config)
    { 
        services.AddSingleton(config.GetSection("TPIE").Get<TPIEConfig>());

        return services; 
    }
        
}
