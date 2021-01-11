/*
* Please do not change this file
*/
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atom.ImageProcessor.Api.Interfaces
{
    public interface IImageRetriever
    {
        Task<IReadOnlyCollection<string>> GetImageCatalogue();
        Task<string> GetImageFilePath(string fileName);
    }
}
