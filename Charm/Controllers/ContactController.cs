using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Charm.Controllers
{
    [RequireHttps]
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {

            return View();
        }

        // POST: Contact
        [HttpPost]
        public ActionResult Index(string contactname, string email, string subject, string comments)
        {
            IdentityMessage message = new IdentityMessage();
            EmailService emails = new EmailService();

            message.Subject = subject;
            message.Destination = ConfigurationManager.AppSettings["ContactEmail"];
            message.Body = "From:" + contactname + "\nEmail: " + email + "\n" + comments;
            emails.SendAsync(message);
            return RedirectToAction("Index");
        }
    }
}