using Atom.ImageProcessor.Api.Interfaces;
using Microsoft.Extensions.Configuration;
using System;

namespace Atom.ImageProcessor.Api.Implementations
{
    public class ImageSettings : IImageSettings
    {
        private readonly IConfigurationSection _imageSection;

        public ImageSettings(IConfiguration configuration)
        {
            _imageSection = configuration.GetSection("Atom:Image");
        }

        public string ImageDirectory => $"{AppDomain.CurrentDomain.BaseDirectory}\\{_imageSection["Directory"]}";
    }
}
