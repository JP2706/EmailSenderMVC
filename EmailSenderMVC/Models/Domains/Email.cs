using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data;

namespace EmailSenderMVC.Models.Domains
{
    public class Email
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Treść")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Odbiorca jest wymagany")]
        [Display(Name = "Odbiorcy")]
        public string Receivers { get; set; }

        [Display(Name = "Nazwa Nadawcy")]
        public string SenderName { get; set; }
        public DateTime CreatedDate { get; set; }

        [Required]
        [ForeignKey("User")]
        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

    }
}