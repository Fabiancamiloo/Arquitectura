using NorthWind.Writers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddCNorthWindServices(
        this IServiceCollection services)
    {
        services.AddDebugWriter();
        services.AddServices(9);
        return services;
    }
} 
