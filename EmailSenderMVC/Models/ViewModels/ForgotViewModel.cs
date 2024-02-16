using System.ComponentModel.DataAnnotations;

namespace EmailSenderMVC.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
    }
}
