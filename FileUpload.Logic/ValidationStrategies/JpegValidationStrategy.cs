using FileUpload.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FileUpload.Logic.ValidationStrategies
{
    public class JpegValidationStrategy : IValidationStrategy
    {
        public ValidationDTO ValidationStrategy(IFormFile file)
        {
            return new ValidationDTO
            {
                ValidExtentions = new[]
                {
                    ".jpg",
                    ".jpeg"
                },
                ValidMimeTypes = new[] {
                    "image/jpeg"
                },
                MaxFileSize = 50000
            };
        }
    }
}
