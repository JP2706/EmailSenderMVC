﻿using EmailSenderMVC.Models.Domains;
using System.ComponentModel.DataAnnotations;

namespace EmailSenderMVC.Models
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi zawierać co najmniej następującą liczbę znaków: {2}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasło i jego potwierdzenie są niezgodne.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Nazwa Użytkownika")]
        public string UserName { get; set; }

        public SentEmailAcountParams SentEmailAcountParams { get; set; }
    }
}
