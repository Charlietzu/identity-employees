using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebEmployee.ViewModels
{
    public class EditRoleViewModel
    {
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "The role name is required")]
        public string RoleName { get; set; }

        public List<string> Users { get; set; }
    }
}
