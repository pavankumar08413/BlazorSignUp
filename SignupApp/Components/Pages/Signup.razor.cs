// using System.ComponentModel.DataAnnotations;
// using Microsoft.AspNetCore.Components;

// public partial class Signup
// {
//     // ✅ Property renamed to avoid conflict
//     protected SignupModel oModel { get; } = new();

//     [Inject]
//     protected NavigationManager Navigation { get; set; } = default!;

//     protected void HandleValidSubmit()
//     {
//         Navigation.NavigateTo("/");
//     }

//     protected void HandleInvalidSubmit()
//     {
//         // Stay on page and show validation errors
//     }

//     // ✅ Nested type keeps its name
//     protected class SignupModel : IValidatableObject
//     {
//         [Required(ErrorMessage = "First name is required")]
//         [MinLength(2)]
//         public string FirstName { get; set; }

//         [Required]
//         public string LastName { get; set; }

//         [Required]
//         [Range(18, 50)]
//         public int? Age { get; set; }

//         [Required]
//         [EmailAddress]
//         public string Email { get; set; }

//         [Required]
//         public DateTime? DateOfBirth { get; set; }

//         public IEnumerable<ValidationResult> Validate(ValidationContext context)
//         {
//             if (Age.HasValue && DateOfBirth.HasValue)
//             {
//                 var today = DateTime.Today;
//                 var calculatedAge = today.Year - DateOfBirth.Value.Year;

//                 if (DateOfBirth.Value.Date > today.AddYears(-calculatedAge))
//                     calculatedAge--;

//                 if (calculatedAge != Age.Value)
//                 {
//                     yield return new ValidationResult(
//                         "Age does not match Date of Birth",
//                         new[] { nameof(DateOfBirth) });
//                 }
//             }
//         }
//     }
// }