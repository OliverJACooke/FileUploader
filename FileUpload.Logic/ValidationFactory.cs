using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.Logic
{
    public class ValidationFactory : IValidationFactory
    {
        public string Make(ValidFileTypes fileType)
        {
            switch (fileType)
            {
                case ValidFileTypes.Jpeg:
                    return "void";
                default:
                    throw new FileUploadException("Unathorised File Format");
            }
        }
    }
}
