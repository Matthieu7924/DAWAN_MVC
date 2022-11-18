using System.ComponentModel.DataAnnotations;

namespace _07_Identity.ViewModels
{
	public class CreateRoleViewModel
	{
		[Required]
		public string RoleName { get; set; }= String.Empty;
	}
}
