using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using FileUpload.DTOs;

namespace FileUpload.Logic
{
    public enum ValidFileTypes
    {
        Jpeg = 1
    }

    public interface IValidationStrategy
    {
        ValidationDTO ValidationStrategy(IFormFile file);
    }
}
