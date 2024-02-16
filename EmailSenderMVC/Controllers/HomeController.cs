using EmailSenderMVC.Models.Domains;
using EmailSenderMVC.Models.Repositories;
using EmailSenderMVC.Models.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace EmailSenderMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private DataBaseRepository _dataBaseRepository = new DataBaseRepository();
        private SentRepository _sentRepository = new SentRepository();
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            var vm = _dataBaseRepository.GetEmails(userId);
            return View(vm);
        }

        public ActionResult SentEmailView(int id = 0)
        {
            var userId = User.Identity.GetUserId();

            var email = GetNewEmail(userId);

            var vm = PrepareEditSentEmailVM(email, "Nowa wiadomość");

            return View(vm);
        }

        private Email GetNewEmail(string userId)
        {
            return new Email
            {
                UserId = userId,
                //CreatedDate = DateTime.Now,
            };
        }

        private EditSentEmailViewModel PrepareEditSentEmailVM(Email email, string heading)
        {
            return new EditSentEmailViewModel
            {
                Heading = heading,
                Email = email
            };
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SentEmail(Email email)
        {
            var userId = User.Identity.GetUserId();
            email.UserId = userId;

            //if (!ModelState.IsValid)
            //{ 
            //    var vm = PrepareEditSentEmailVM(email);
            //     return View("SentEmailView", vm);
            //}
            var param = _dataBaseRepository.GetSentEmailAcountParams(userId);
            _sentRepository.GetParams(param);
            if (_sentRepository.SentEmail(email))
                _dataBaseRepository.AddEmailToDatabase(email);

            return RedirectToAction("Index", "Home");
        }

        public ActionResult CheckEmailView(int id)
        {
            var userId = User.Identity.GetUserId();
            var email = _dataBaseRepository.GetEmail(id, userId);
            var vm = PrepareEditSentEmailVM(email, email.Title);

            return View(vm);
        }

    }
}