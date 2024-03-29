﻿using System.ComponentModel.DataAnnotations;

namespace EmailSenderMVC.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }
    }
}
