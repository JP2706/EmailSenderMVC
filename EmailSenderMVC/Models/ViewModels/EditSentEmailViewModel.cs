using EmailSenderMVC.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSenderMVC.Models.ViewModels
{
    public class EditSentEmailViewModel
    {
        public string Heading { get; set; }
        public Email Email { get; set; }

    }
}