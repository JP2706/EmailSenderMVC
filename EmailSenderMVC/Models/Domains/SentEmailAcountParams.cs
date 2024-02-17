using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmailSenderMVC.Models.Domains
{
    public class SentEmailAcountParams
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Host Smtp jest wymagany")]
        [Display(Name = "Host Smtp")]
        public string HostSmtp { get; set; }

        
        [Display(Name = "Ssl")]
        public bool EnableSsl { get; set; }

        [Required(ErrorMessage = "Port jest wymagany")]
        [Display(Name = "Port")]
        public int Port { get; set; }

        [Required(ErrorMessage = "Adres Nadawczy jest wymagany")]
        [Display(Name = "Adres Nadawczy")]
        public string SenderEmail { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [Display(Name = "Hasło")]
        public string SenderEmailPassword { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }



    }
}