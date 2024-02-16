using EmailSenderMVC.Migrations;
using EmailSenderMVC.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace EmailSenderMVC.Models.Repositories
{
    public class SentRepository
    {
        private SmtpClient _smtp;
        private MailMessage _mail;
        private SentEmailAcountParams _params;

        public bool SentEmail(Email email)
        {
            _mail = new MailMessage();
            _mail.From = new MailAddress(_params.SenderEmail, email.SenderName);
            var receivers = email.Receivers.Split(';');
            foreach(var receiver in receivers) 
            {
                _mail.To.Add(new MailAddress(receiver));
            }
            _mail.Subject = email.Title;
            _mail.Body = email.Body;

            _smtp = new SmtpClient
            {
                Host = _params.HostSmtp,
                EnableSsl = _params.EnableSsl,
                Port = _params.Port,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(_params.SenderEmail, _params.SenderEmailPassword)
            };

            try
            {
                _smtp.Send(_mail);
               
            }
            catch (Exception )
            {
                return false;
            }

            return true;
     
        }

        public void GetParams(SentEmailAcountParams param)
        {
            _params = param;
        }
    }
}