using EmailSenderMVC.Models.Domains;
using Microsoft.Owin.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSenderMVC.Models.Repositories
{
    public class DataBaseRepository
    {
        public void AddEmailToDatabase(Email email)
        {
            using(var context = new ApplicationDbContext())
            {
                email.CreatedDate = DateTime.Now;
                context.Emails.Add(email);
                context.SaveChanges();
            }
        }

        public List<Email> GetEmails(string userId) 
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Emails.Where(x => x.UserId == userId).ToList();
            }
        }

        public Email GetEmail(int id, string userId) 
        {
            using (var context = new ApplicationDbContext()) 
            {
                return context.Emails.Single(x => x.Id == id && x.UserId == userId);
            }
        }

        public void AddSmtpParams(SentEmailAcountParams smtpParams, string userId)
        {
            using (var context = new ApplicationDbContext())
            {
                smtpParams.UserId = userId;
                context.SentEmailAcountParamss.Add(smtpParams);
                context.SaveChanges();
            }
        }

        public SentEmailAcountParams GetSentEmailAcountParams(string userId) 
        {
            using (var context = new ApplicationDbContext())
            {
                return context.SentEmailAcountParamss.Single(x => x.UserId == userId);
            }
        }
    }
}