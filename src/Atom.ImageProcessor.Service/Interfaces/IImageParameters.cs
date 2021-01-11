/*
* Please do not change this file
*/
namespace Atom.ImageProcessor.Service.Interfaces
{
    public interface IImageParameters
    {
        string FilePath { get; }
        (int height, int width)? Resolution { get; }
        (int red, int blue, int green)? Background { get; }
        string Watermark { get; }
        string FileType { get; }
    }
}
