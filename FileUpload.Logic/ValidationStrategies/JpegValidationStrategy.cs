using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.Logic.ValidationStrategies
{
    public class JpegValidationStrategy : IValidationStrategy
    {
        public void ValidateFile(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
