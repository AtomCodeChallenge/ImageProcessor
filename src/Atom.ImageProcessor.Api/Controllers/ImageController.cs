using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;

namespace Atom.ImageProcessor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly ILogger<ImageController> _logger;
        private readonly string _imageDirectory;

        public ImageController(ILogger<ImageController> logger)
        {
            _logger = logger;
            _imageDirectory = $"{AppDomain.CurrentDomain.BaseDirectory}\\Images";
        }

        [HttpGet]
        public string Get()
        {
            var fileList = Directory.GetFiles($"{_imageDirectory}");

            return string.Join($"{Environment.NewLine}", fileList.Select(f => Path.GetFileName(f)));
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetImage(string id)
        {
            var fileList = Directory.GetFiles($"{_imageDirectory}");

            var imageBytes = System.IO.File.ReadAllBytes(fileList.Where(f => Path.GetFileName(f).Equals(id)).First());

            return File(imageBytes, "image/png");
        }
    }
}
