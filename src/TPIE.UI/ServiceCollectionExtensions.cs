using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TPIE.UI;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Extension Method to setup all the TPIE.UI Dependencies.
    /// </summary>
    /// <param name="services">The Service Collection for DI.</param>
    /// <param name="config">The configuration.</param>
    /// <returns></returns>
    public static IServiceCollection SetupTPIEUI(this IServiceCollection services, IConfiguration configuration)
        => services.SetupTPIE(configuration)
                    .InternalSetup();

    /// <summary>
    /// Extension Method to setup all the TPIE.UI Dependencies.
    /// </summary>
    /// <param name="services">The Service Collection for DI.</param>
    /// <param name="config">The configuration.</param>
    /// <returns></returns>
    public static IServiceCollection SetupTPIEUI(this IServiceCollection services, Action<TPIEConfig> config)
        => services.SetupTPIE(config)
                    .InternalSetup();

    static IServiceCollection InternalSetup(this IServiceCollection services)
        => services.AddBlazorise(options =>
                    {
                        options.Immediate = true;
                    })
                    .AddBulmaProviders()
                    .AddFontAwesomeIcons();
}
