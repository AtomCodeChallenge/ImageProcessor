using Atom.ImageProcessor.Api.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Atom.ImageProcessor.Api.Implementations
{
    public class ImageRetriever : IImageRetriever
    {
        private readonly IImageSettings _imageSettings;

        public ImageRetriever(
            IImageSettings imageSettings)
        {
            _imageSettings = imageSettings;
        }

        public Task<string> GetImageFilePath(string fileName)
        {
            var images = Directory
                .GetFiles(_imageSettings.ImageDirectory);

            var imageFilePath = images
                .Where(i => Path.GetFileName(i).Equals(fileName, StringComparison.InvariantCultureIgnoreCase))
                .FirstOrDefault();

            return Task.FromResult(imageFilePath);
        }

        public Task<IReadOnlyCollection<string>> GetImageCatalogue()
        {
            var images = GetImagesNamesInDirectory();

            return Task.FromResult(images);
        }

        private IReadOnlyCollection<string> GetImagesNamesInDirectory()
        {
            var imageFiles = Directory
                .GetFiles(_imageSettings.ImageDirectory);

            var images = imageFiles
                .Select(i => Path.GetFileName(i))
                .ToList()
                .AsReadOnly();

            return images;
        }
    }
}
