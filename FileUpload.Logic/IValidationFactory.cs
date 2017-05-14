using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileUpload.Logic
{
    public interface IValidationFactory
    {
        IValidationStrategy Make(ValidFileTypes fileType);
    }
}
