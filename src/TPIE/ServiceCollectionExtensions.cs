using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TPIE;

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

    /// <summary>
    /// Extension Method to setup all the TPIE Dependencies.
    /// </summary>
    /// <param name="services">The Service Collection for DI.</param>
    /// <param name="config">The configuration to use.</param>
    /// <returns></returns>
    public static IServiceCollection SetupTPIE(this IServiceCollection services, Action<TPIEConfig> config)
    {
        var runningConfig = new TPIEConfig();
        config(runningConfig);
        services.AddSingleton<TPIEConfig>(runningConfig);

        return services;
    }
}
