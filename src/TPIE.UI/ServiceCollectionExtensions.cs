using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Extension Method to setup all the TPIE Dependencies.
    /// </summary>
    /// <param name="services">The Service Collection for DI.</param>
    /// <returns></returns>
    public static IServiceCollection SetupTPIE_UI(this IServiceCollection services, IConfiguration configuration)
        => services.SetupTPIE(configuration)
                    .AddBlazorise(options =>
                    {
                        options.Immediate = true;
                    })
                    .AddBulmaProviders()
                    .AddFontAwesomeIcons();
}
