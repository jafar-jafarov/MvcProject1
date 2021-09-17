using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class ContactController : Controller
    {
        Context context = new Context();
        //MessageManager cm1 = new MessageManager(new EfMessageDal());
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        // GET: Contact
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();

            return View(contactvalues);
        }
        public ActionResult GetContactDetails(int id)
        {
            var contactvalues=cm.GetById(id);
            return View(contactvalues);
        }
        public PartialViewResult ContactAbout()
        {
            var contact1 = cm.GetList().Count();
            //var deyer1 = context.Contacts.Count(x=>x.ContactId==1).ToString();
           ViewBag.contact = contact1;

            var receiverMail = cm.GetList().Count();
            ViewBag.receiverMail = receiverMail;
            return PartialView();
        }
    }
}