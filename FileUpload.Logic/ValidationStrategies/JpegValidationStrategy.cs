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
        public ValidationDTO ValidateFile(IFormFile file)
        {
            return new ValidationDTO
            {
                ValidExtentions = new[]
                {
                    ""
                },
                ValidMimeTypes = new[] {
                    ""
                },
                MaxFileSize = 50000
            };
        }
    }
}
