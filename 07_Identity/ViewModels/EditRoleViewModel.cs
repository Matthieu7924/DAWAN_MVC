using System.ComponentModel.DataAnnotations;

namespace _07_Identity.ViewModels
{
    public class EditRoleViewModel
    {
        [Required]
        public string RoleUserName { get; set; } = String.Empty;


        [Required]
        public string RoleName { get; set; } = String.Empty;
    }
}









