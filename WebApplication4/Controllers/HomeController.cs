using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
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


        public ActionResult PersonContent()
        {
            ViewBag.Message = "Your contact Person Content.";
            

            return View();
        }

        public ActionResult Sample1()
        {
            ViewBag.Message = "this is a sample";


            return View();
        }
    }
}