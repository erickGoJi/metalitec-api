﻿using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace api.metalitec.project.ModelFilter
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }
    
        protected override ValidationResult IsValid(
            object value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!((IList) _extensions).Contains(extension.ToLower()))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
        
            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"This photo extension is not allowed!";
        }
    }
}