using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace FileUpload.Logic
{
    public class ProcessUpload : IProcessUpload
    {
        public void ValidateUpload(IFormFile file)
        {
            throw new NotImplementedException();
        }
    }
}
