using System.ComponentModel.DataAnnotations;

namespace ModelVelidationExample.ModelValidation
{
    public class ClassValidationAttribute: ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null) { 
             DateTime date=(DateTime)value;
                if (date.Year >= 2000)
                {

                    return new ValidationResult("Minimum year allowd is 2000");
                }
                else {
                    return ValidationResult.Success;

                }
            }
            return null;
        }

    }
}
