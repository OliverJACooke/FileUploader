using Microsoft.AspNetCore.Http;
using System;

namespace FileUpload.Logic
{
    public interface IProcessUpload
    {
        void ValidateUpload(IFormFile file);
    }
}
