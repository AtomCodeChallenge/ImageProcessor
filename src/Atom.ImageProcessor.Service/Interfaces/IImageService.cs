/*
* Please do not change this file
*/
using System.Threading.Tasks;

namespace Atom.ImageProcessor.Service.Interfaces
{
    public interface IImageService
    {
        Task<bool> ValidateParameters(IImageParameters imageParameters);
        Task<byte[]> GetImage(IImageParameters imageParameters);
    }
}
