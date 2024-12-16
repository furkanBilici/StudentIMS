using System.ComponentModel.DataAnnotations;

namespace StudentIMS.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
