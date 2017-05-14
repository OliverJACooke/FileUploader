using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.DTOs
{
    public class ValidationDTO
    {
        public string[] ValidExtentions { get; set; }
        public string[] ValidMimeTypes { get; set; }
        public int MaxFileSize { get; set; }
    }
}
