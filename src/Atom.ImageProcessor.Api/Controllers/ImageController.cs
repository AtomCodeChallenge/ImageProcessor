using Atom.ImageProcessor.Api.Interfaces;
using Atom.ImageProcessor.Service.Interfaces;
using Atom.ImageProcessor.Service.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Atom.ImageProcessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly ILogger<ImageController> _logger;
        private readonly IImageRetriever _imageRetriever;
        private readonly IImageService _imageService;

        public ImageController(
            ILogger<ImageController> logger,
            IImageRetriever imageRetriever,
            IImageService imageService)
        {
            _logger = logger;
            _imageRetriever = imageRetriever;
            _imageService = imageService;
        }

        [HttpGet]
        public async Task<IReadOnlyCollection<string>> Get()
        {
            var imageCatalogue = new string[] { "image_1.png", "image_2.png", "image_3.png" };

            _logger.LogInformation("Retrieved images: [{imageCatalogue}]", imageCatalogue);

            return imageCatalogue;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetImage(
            string id,
            [FromQuery] int height,
            [FromQuery] int width,
            [FromQuery] string colour,
            [FromQuery] string watermark,
            [FromQuery] string fileType)
        {
            var imageFilePath = await _imageRetriever.GetImageFilePath(id);

            var imageParameters = new ImageParameters(imageFilePath);

            var valid = await _imageService.ValidateParameters(imageParameters);

            _logger.LogInformation("Request for [{id}] is valid: [{valid}]", id, valid);

            if(valid)
            {
                var imageBytes = await _imageService.GetImage(imageParameters);

                return File(imageBytes, imageParameters.FileType);
            }

            return NotFound();
        }
    }
}
