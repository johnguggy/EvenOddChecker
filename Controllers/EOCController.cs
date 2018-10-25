using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvenOddCheckerMVC.Controllers
{
    public class EOCController : Controller
    {
        // GET: EOC
        public ActionResult Index()
        {
            Random random = new Random();
            int num1 = random.Next(100);
            ViewBag.num1 = num1;
            return View();
        }
    }
}