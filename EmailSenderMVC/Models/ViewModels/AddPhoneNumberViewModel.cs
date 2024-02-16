using System.ComponentModel.DataAnnotations;

namespace EmailSenderMVC.Models
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Numer telefonu")]
        public string Number { get; set; }
    }
}