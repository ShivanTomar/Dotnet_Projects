using System.ComponentModel.DataAnnotations;
using ModelVelidationExample.ModelValidation;
namespace ModelVelidationExample.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage = "{0} can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} Should be More then 3 letters less then 50")]
        public string? PersonName { get; set; }
        [EmailAddress(ErrorMessage = "{0} Its email")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "{0} Enter 10 digit phone number")]
        public string? Phone { get; set; }
        //[Required(ErrorMessage = "{0}  mention the password")]
        public string? Password { get; set; }
        [Compare("Password", ErrorMessage = "{0} and {1} Not same")]
        [Display(Name = "Re-Enter the password")]
        public string? ConfirmPassword { get; set; }
        public double? Price { get; set; }

        [ClassValidationAttribute(ErrorMessage = "enter in yyyy-mm-dd formate")]
        public DateTime? DateOfBirth { get; set; }

        public int? Age { get; set; }
        public override string ToString()
        {
            return $"Person object - Person Name:{PersonName}, Email:{Email}" +
                $"Phone number: {Phone} , Password: {Password}, ConfirmPassword: {ConfirmPassword}, Price: {Price}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        //IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        //{
        //    //if (DateOfBirth.HasValue == false && Age.HasValue == false)
        //    //{
        //    //   yield return new ValidationAttribute("Either of birth or age must be supplied", new[] { nameof(Age) });
        //    //}
        //}

    }
}
