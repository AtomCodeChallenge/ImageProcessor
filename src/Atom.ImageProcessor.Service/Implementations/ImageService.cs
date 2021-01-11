using Atom.ImageProcessor.Service.Interfaces;
using System.IO;
using System.Threading.Tasks;

namespace Atom.ImageProcessor.Service.Implementations
{
    public class ImageService : IImageService
    {
        public Task<byte[]> GetImage(IImageParameters imageParameters)
        {
            var imageBytes = File.ReadAllBytes(imageParameters.FilePath);

            return Task.FromResult(imageBytes);
        }

        public Task<bool> ValidateParameters(IImageParameters imageParameters)
        {
            return Task.FromResult(true);
        }
    }
}
