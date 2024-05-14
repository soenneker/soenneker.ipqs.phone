using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Ipqs.Client.Registrars;
using Soenneker.Ipqs.Phone.Abstract;

namespace Soenneker.Ipqs.Phone.Registrars;

/// <summary>
/// A utility library for IPQualityScore phone related operations
/// </summary>
public static class IpqsPhoneUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IIpqsPhoneUtil"/> as a singleton service. <para/>
    /// </summary>
    public static void AddIpqsPhoneUtilAsSingleton(this IServiceCollection services)
    {
        services.AddIpqsClientUtilAsSingleton();
        services.TryAddSingleton<IIpqsPhoneUtil, IpqsPhoneUtil>();
    }

    /// <summary>
    /// Adds <see cref="IIpqsPhoneUtil"/> as a scoped service. <para/>
    /// </summary>
    public static void AddIpqsPhoneUtilAsScoped(this IServiceCollection services)
    {
        services.AddIpqsClientUtilAsSingleton();
        services.TryAddScoped<IIpqsPhoneUtil, IpqsPhoneUtil>();
    }
}
