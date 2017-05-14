using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.Logic
{
    public class FileUploadException : Exception
    {
        public FileUploadException(string message) : base(message)
        {
        }
    }
}
