using FileUpload.Logic.ValidationStrategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.Logic
{
    public class ValidationFactory : IValidationFactory
    {
        public IValidationStrategy Make(ValidFileTypes fileType)
        {
            switch (fileType)
            {
                case ValidFileTypes.Jpeg:
                    return new JpegValidationStrategy();
                default:
                    throw new FileUploadException("Unathorised File Format");
            }
        }
    }
}
