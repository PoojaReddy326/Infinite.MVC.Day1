using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinite.MVC.Day1.Controllers
{
    public class HomeController : Controller
    {
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
        public RedirectResult MyUrl()
        {
            return Redirect("https://www.youtube.com/");
        }



        public RedirectToRouteResult MyView()
        {
            return RedirectToAction("About");
        }



        public ContentResult MyContent()
        {
            return Content("Hello");
        }



        public JsonResult MyJson()
        {
            var product = new { id = "1001", Name = "Pen", Price = 10 };
            return Json(product, JsonRequestBehavior.AllowGet);
        }
    }
}