using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebEmployee.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            Claims = new List<string>();
            Roles = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Email is required"), EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }


        public string City { get; set; }
        public List<string> Claims { get; set; }
        public List<string> Roles { get; set; }
    }
}
