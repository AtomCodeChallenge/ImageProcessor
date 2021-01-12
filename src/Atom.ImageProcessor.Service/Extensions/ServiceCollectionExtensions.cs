using Atom.ImageProcessor.Service.Implementations;
using Atom.ImageProcessor.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Atom.ImageProcessor.Service.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddImageProcessorServices(this IServiceCollection services)
        {
            services.AddSingleton<IImageService, ImageService>();

            return services;
        }
    }
}
