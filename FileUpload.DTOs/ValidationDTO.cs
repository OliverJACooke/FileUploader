using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.DTOs
{
    public class ValidationDTO
    {
        IEnumerable<string> ValidExtentions;
        IEnumerable<string> ValidMimeTypes;
        int MaxFileSize;
    }
}
