using BlazorApp.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.RequestModels
{
    public class RegisterRequestModel : EmailRequestModel
    {
        [CustomRegularExpression(ModelRegularExpression.REG_ONE_LATER_DIGIT, ErrorMessage = "Password should contain at least one letter and one digit")]
        [CustomRegularExpression(ModelRegularExpression.REG_NOT_CONTAIN_SPACES_ONLY, ErrorMessage = "Password can’t contain spaces only")]
        [Required(ErrorMessage = "Password field is empty")]
        [StringLength(50, ErrorMessage = "Password should be from 6 to 50 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm Password isn’t the same as Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "FirstName field is empty")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName field is empty")]
        public string LastName { get; set; }
    }
}

