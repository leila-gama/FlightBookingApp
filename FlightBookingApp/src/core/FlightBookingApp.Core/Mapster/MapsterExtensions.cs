using AutoMapper;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FlightBookingApp.Core.Mapster
{
    public static class MapsterExtensions
    {
        public static IServiceCollection AddCustomMapster(this IServiceCollection services, Assembly assembly)
        {
            var typeAdapterConfig = TypeAdapterConfig.GlobalSettings;

            typeAdapterConfig.Scan(assembly);
            var mapperConfig = new AutoMapper.Mapper((IConfigurationProvider)typeAdapterConfig);

            services.AddSingleton<AutoMapper.IMapper>(mapperConfig);

            return services;
        }
    }
}
