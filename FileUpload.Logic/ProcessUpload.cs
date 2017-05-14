using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace FileUpload.Logic
{
    public class ProcessUpload : IProcessUpload
    {
        public void ProcessUploadedFile(IFormFile file)
        {
            if (file == null || file.Length < 0)
            {
                throw new FileUploadException("No file found");
            }

            string fileExtention = Path.GetExtension(file.FileName);


        }
    }
}
