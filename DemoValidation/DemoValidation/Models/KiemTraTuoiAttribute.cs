using System;
using System.ComponentModel.DataAnnotations;

namespace DemoValidation.Models
{
    internal class KiemTraTuoiAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var dataInput = (DateTime)value;

            var tuoi = DateTime.Now.Year - dataInput.Year;

            if(tuoi < 18 || tuoi > 60)
            {
                return new ValidationResult("Tuổi từ 18 - 60");
            }

            return ValidationResult.Success;
        }
    }
}