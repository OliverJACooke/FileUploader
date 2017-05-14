using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace FileUpload.Logic
{
    public enum ValidFileTypes
    {
        Jpeg = 1
    }

    public interface IValidationStrategy
    {
        void ValidateFile(IFormFile file);
    }
}
