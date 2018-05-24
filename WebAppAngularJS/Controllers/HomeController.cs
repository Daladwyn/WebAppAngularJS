using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAngularJS.Models;

namespace WebAppAngularJS.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult CarList()
        {
            return Json(db.Cars,JsonRequestBehavior.AllowGet);
        }

        public JsonResult PeopleList()
        {
            return Json(db.People, JsonRequestBehavior.AllowGet);
        }

        public  JsonResult AddPerson(Person person)
        {
            db.People.Add(person);
            db.SaveChanges();
            return Json(person, JsonRequestBehavior.AllowGet);
        }
    }
}