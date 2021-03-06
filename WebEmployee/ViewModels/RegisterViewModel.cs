using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace WebEmployee.ViewModels
{
    public class RegisterViewModel
    {
        [Required, EmailAddress, Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Display(Name = "Confirm your password"), Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public string City { get; set; }

    }
}
