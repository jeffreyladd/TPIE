using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Extension Method to setup all the TPIE Dependencies.
    /// </summary>
    /// <param name="services">The Service Collection for DI.</param>
    /// <returns></returns>
    public static IServiceCollection SetupTPIE(this IServiceCollection services)
        => services
                    .AddBlazorise(options =>
                    {
                        options.Immediate = true;
                    })
                    .AddBulmaProviders()
                    .AddFontAwesomeIcons();
}
