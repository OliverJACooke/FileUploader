using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FileUpload.Logic;

namespace FileUpload.Controllers
{
    [Route("api/[controller]")]
    public class UploadController : Controller
    {
        public readonly IProcessUpload _processUpload;

        public UploadController(IProcessUpload processUpload)
        {
            _processUpload = processUpload;
        }

        [HttpPost]
        public IActionResult Post(IFormFile file)
        {
            _processUpload.ValidateUpload(file);

            return Ok();
        }

        [HttpGet]
        public string GetHelloWorld()
        {
            return "Hello World!";
        }
    }
}
