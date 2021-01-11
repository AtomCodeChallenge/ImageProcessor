using Atom.ImageProcessor.Service.Interfaces;

namespace Atom.ImageProcessor.Service.Models
{
    public class ImageParameters : IImageParameters
    {
        private readonly string _filePath;
        private readonly (int height, int width)? _resolution;
        private readonly (int red, int blue, int green)? _background;
        private readonly string _watermark;
        private readonly string _fileType;

        public ImageParameters(
            string filePath,
            (int height, int width)? resolution = null,
            (int red, int blue, int green)? background = null,
            string watermark = null,
            string fileType = "image/png")
        {
            _filePath = filePath;
            _resolution = resolution;
            _background = background;
            _watermark = watermark;
            _fileType = fileType;
        }

        public string FilePath => _filePath;

        public (int height, int width)? Resolution => _resolution;

        public (int red, int blue, int green)? Background => _background;

        public string Watermark => _watermark;

        public string FileType => _fileType;
    }
}
