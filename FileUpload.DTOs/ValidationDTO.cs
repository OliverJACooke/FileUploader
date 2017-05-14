using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.DTOs
{
    public class ValidationDTO
    {
        public string[] ValidExtentions;
        public string[] ValidMimeTypes;
        public int MaxFileSize;
    }
}
